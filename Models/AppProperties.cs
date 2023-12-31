﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Models
{
    public static class AppProperties
    {
        private static Version? _AppVersion;

        /// <summary>
        /// Application version
        /// </summary>
        public static Version AppVersion
        {
            get
            {
                if (_AppVersion == null)
                {
                    _AppVersion = Assembly.GetExecutingAssembly().GetName()?.Version ?? new Version(1, 0, 0, 0);
                }

                return _AppVersion;
            }
        }

        private static string _AppName = string.Empty;

        /// <summary>
        /// Application name
        /// </summary>
        public static string AppName
        {
            get
            {
                if (string.IsNullOrEmpty(_AppName))
                {
                    _AppName = Assembly.GetExecutingAssembly().GetName()?.Name ?? "Quantum";
                }

                return _AppName;
            }
        }

        /// <summary>
        /// Default application height, mostly used in binding and grid calculation
        /// </summary>
        public static int kDefaultHeight { get; private set; } = 650;

        /// <summary>
        /// Default application width, mostly used in binding and grid calculations
        /// </summary>
        public static int kDefaultWidth { get; private set; } = 1200;

        /// <summary>
        /// Whether we are in release mode or not
        /// </summary>
#if DEBUG
        public const bool IsRelease = false;
#else
        public const bool IsRelease = true;
#endif
    }
}
