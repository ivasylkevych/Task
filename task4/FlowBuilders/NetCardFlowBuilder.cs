// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace task4.FlowBuilders
{
    #region Usings

    using System.Collections.Generic;
    using task4.DataStructures;

    #endregion

    /// <summary>
    /// Flow builder. Overrides Prepare(), Run(), Clean() methods of the test template.
    /// </summary>
    public abstract class NetCardFlowBuilder : NetCardTestTemplate
    {

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCardFlowBuilder" /> class.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testDescription"></param>
        public NetCardFlowBuilder(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers
        /// <summary>
        /// Dictionary "portsSpeed" containing Name of Port and Ports Speed depending on the launched Test Case; 
        /// Overrides with Test Case;
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
        };

        /// <summary>
        /// Type of reset, which test is using.
        /// </summary>
        public override ResetTypes ResetTypeToTrigger => ResetTypes.AnyReset;

        #endregion

        #region Methods

        /// <summary>
        /// Method for clearing the number of ports and speeds.
        /// </summary>
        public void Clean()
        {
            // Stub.
        }

        /// <summary>
        /// Method for values substitution of ports and speeds.
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool Prepare()
        {
            bool retVal = true;

            retVal &= this.TempTestMethod();
            retVal &= this.SetPortsSpeed(); // Return method of setting the port speed configurations.
            retVal &= this.SetQuantityOfPorts(); // Return method of ports number configuration setting value.

            return retVal;
        }

        /// <summary>
        /// Method for launching a test case.
        /// </summary>
        public void Run()
        {
            this.TotalPortsSpeed(); // Method that returns the correctness of the overall speed of the ports.
        }

        #endregion
    }
}


