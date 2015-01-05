﻿namespace Ninject.Extensions.Logging.Serilog.Test.Infrastructure
{
    using System;
    using global::Serilog;
    using Ninject.Extensions.Logging.Infrastructure;
    using Ninject.Extensions.Logging.Serilog;
    using Ninject.Extensions.Logging.Serilog.Infrastructure;
    using Ninject.Modules;

    public abstract class SerilogTestingContext : CommonTests
    {
        private readonly INinjectModule module;

        static SerilogTestingContext()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.ColoredConsole().CreateLogger();
        }

        public SerilogTestingContext()
        {
            this.module = new SerilogModule();
        }

        public override INinjectModule[] TestModules
        {
            get { return new[] { this.module }; }
        }

        public override Type LoggerType
        {
            get { return typeof(SerilogLogger); }
        }
    }
}