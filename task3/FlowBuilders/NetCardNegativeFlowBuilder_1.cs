// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace task3.FlowBuilders
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>
    /// Negative Flow builder. Overrides Prepare(), Run(), Clean() methods of the test template.
    /// </summary>
    public abstract class NetCardNegativeFlowBuilder
    {
        #region Fields and Constants



        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCardNegativeFlowBuilder" /> class.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testDescription"></param>
        public NetCardNegativeFlowBuilder(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers



        #endregion
    }
}
