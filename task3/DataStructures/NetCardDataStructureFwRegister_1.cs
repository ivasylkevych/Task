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
    /// Data Structure FW Register.
    /// </summary>
    public class NetCardDataStructureFwRegister
    {

        /// <summary>
        /// Enum in which contains speed values of 8 ports of network card.
        /// </summary>
        public enum Registers
        {
            /// <summary>
            /// 1st port state register.
            /// </summary>
            Port1Speed,

            /// <summary>
            /// 2nd port state register.
            /// </summary>
            Port2Speed,

            /// <summary>
            /// 3rd port state register.
            /// </summary>
            Port3Speed,

            /// <summary>
            /// 4th port state register.
            /// </summary>
            Port4Speed,

            /// <summary>
            /// 5th port state register.
            /// </summary>
            Port5Speed,

            /// <summary>
            /// 6th port state register.
            /// </summary>
            Port6Speed,

            /// <summary>
            /// 7th port state register.
            /// </summary>
            Port7Speed,

            /// <summary>
            /// 8th port state register.
            /// </summary>
            Port8Speed
        }
    }
}
