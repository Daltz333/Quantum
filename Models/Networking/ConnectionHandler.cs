using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Models.Networking
{
    public partial class ConnectionHandler : ObservableObject
    {
        private static ConnectionHandler? _Instance;

        /// <summary>
        /// Retrieve an instance of ConnectionHandler
        /// ConnectionHandler handles the global connection state of the application
        /// </summary>
        public static ConnectionHandler Instance
        {
            get => _Instance ??= new ConnectionHandler();
        }

        private ConnectionHandler() { }

        /// <summary>
        /// Whether NetworkTables is currently connected
        /// </summary>
        [ObservableProperty]
        private bool _IsNtConnected = false;

        /// <summary>
        /// Current ping to the target
        /// </summary>
        [ObservableProperty]
        private bool _IsPingGood = false;
    }
}
