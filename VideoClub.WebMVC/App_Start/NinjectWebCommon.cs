using VideoClub.Repositorios;
using VideoClub.Repositorios.Repositorios;
using VideoClub.Repositorios.Repositorios.Facades;
using VideoClub.Servicios.Servicios;
using VideoClub.Servicios.Servicios.Facades;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VideoClub.WebMVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(VideoClub.WebMVC.App_Start.NinjectWebCommon), "Stop")]

namespace VideoClub.WebMVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRepositorioCalificaciones>().To<RepositorioCalificaciones>().InRequestScope();
            kernel.Bind<IServicioCalificaciones>().To<ServicioCalificaciones>().InRequestScope();

            kernel.Bind<IRepositorioGeneros>().To<RepositorioGeneros>().InRequestScope();
            kernel.Bind<IServicioGeneros>().To<ServicioGeneros>().InRequestScope();

            kernel.Bind<IRepositorioEstados>().To<RepositorioEstados>().InRequestScope();
            kernel.Bind<IServicioEstados>().To<ServicioEstados>().InRequestScope();

            kernel.Bind<IRepositorioSoportes>().To<RepositorioSoportes>().InRequestScope();
            kernel.Bind<IServicioSoportes>().To<ServicioSoportes>().InRequestScope();

            kernel.Bind<IRepositorioPeliculas>().To<RepositorioPeliculas>().InRequestScope();
            kernel.Bind<IServicioPeliculas>().To<ServicioPeliculas>().InRequestScope();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

            kernel.Bind<VideoClubDbContext>().ToSelf().InThreadScope();
        }
    }
}