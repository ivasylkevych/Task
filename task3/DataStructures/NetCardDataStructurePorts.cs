// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace task3.DataStructures
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>
    /// Class which contains enum (name of the class - DataStructurePorts) (different quantity of ports).
    /// </summary>
    public class DataStructurePorts
    {
        /// <summary>
        /// Enum containing different quantity of ports.
        /// </summary>
        public enum QuantityOfPorts
        {
            /// <summary>
            /// Configuration of Network Card with 1 port.
            /// </summary>
            NetCard1Port,

            /// <summary>
            /// Configuration of Network Card with 2 ports.
            /// </summary>
            NetCard2Ports,

            /// <summary>
            /// Configuration of Network Card with 4 ports.
            /// </summary>
            NetCard4Ports,

            /// <summary>
            /// Configuration of Network Card with 8 ports.
            /// </summary>
            NetCard8Ports
        }
    }
}
