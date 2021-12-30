// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace task3
{

    #region Usings

    using System;
    using System.Collections.Generic;
    using task3.DataStructures;

    #endregion

    /// <summary>
    /// Test template.
    /// </summary>
    public abstract class NetCardTestTemplate : EthTestTemplate
    {    

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCardTestTemplate" /> class.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testDescription"></param>
        protected NetCardTestTemplate(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        /// <summary>
        /// Type of reset, which test is using.
        /// </summary>
        public virtual ResetTypes ResetTypeToTrigger => ResetTypes.Por;

        /// <summary>
        /// Dictionary "portsSpeed" containing Name of Port and Ports Speed depending on the launched Test Case; 
        /// Overrides with Test Case;
        /// </summary>
        protected virtual Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {

        };

        #endregion

        #region Public Methods

        /// <summary>
        /// Preconditions of test case.
        /// </summary>
        /// <returns> 
        /// Boolean. 
        /// </returns>
        public bool TempTestMethod() 
        {
            return true;
        }

        /// <summary>
        /// Set speed configurations of ports on Simics.
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool SetPortsSpeed()
        {
            bool retVal = true;

            foreach (KeyValuePair<string, int> kv in this.portsSpeed)
            {
                retVal &= this.SendAdminCommandSetPort(kv.Key, kv.Value);
            }

            return retVal;
        }

        /// <summary>
        /// Method of iterating over values from a dictionary and compliance check.
        /// </summary>
        /// <param name="key">
        /// Test keys from dictionary portsSpeed.
        /// </param>
        /// <param name="value">
        /// Test values from dictionary portsSpeed.
        /// </param>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool SendAdminCommandSetPort(string key, int value)
        {
            bool retVal = true;

            if (key.Contains(key))
            {
                retVal &= true;
            }
            else if (string.IsNullOrEmpty(key))
            {
                retVal &= false;
            }

            if (value == 0 || value == 10 || value == 25 || value == 50 || value == 100)
            {
                retVal &= true;
            }
            else
            {
                retVal &= false;
            }

            return retVal;
        }

        /// <summary>
        /// Method for calculating the number of ports specified in dictionary.
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool SetQuantityOfPorts()
        {
            bool retQuantity = true;
            int quantityOfPorts = this.portsSpeed.Count;
            if (quantityOfPorts == 1 || quantityOfPorts == 2 || quantityOfPorts == 4 || quantityOfPorts == 8)
            {
                for (int i = 0; i < quantityOfPorts; i++)
                { 
                    this.SetPortsToActive(i);
                }
                retQuantity &= true;
            }
            else
            {
                retQuantity &= false;
            }

            return retQuantity;
        }

        /// <summary>
        /// Method of outputting the port configuration setting status.
        /// </summary>
        /// <param name="numOfPort"> 
        /// Variable to which the number of ports is passed.
        /// </param>
        public void SetPortsToActive(int numOfPort)
        {
            Console.WriteLine($"Port {numOfPort} is active now");
        }

        /// <summary>
        /// Method indicating the correctness of the overall port speed according to the requirements.
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool TotalPortsSpeed()
        {
            int totalNetworkCardSpeed = 0;
            bool retTotalPortsSpeed = true;

            foreach (var totalSpeed in this.portsSpeed)
            {
                totalNetworkCardSpeed += totalSpeed.Value;
            }

            if (totalNetworkCardSpeed >= 0 && totalNetworkCardSpeed <= 100)
            {
                retTotalPortsSpeed &= true;
            }
            else
            {
                retTotalPortsSpeed &= false;
            }

            return retTotalPortsSpeed;
        }

        #endregion

        #region Methods



        #endregion
    }
}
