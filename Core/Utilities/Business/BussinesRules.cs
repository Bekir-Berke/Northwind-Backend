using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BussinesRules
    {
        public static IResult Run(params IResult[] logics)
        {
            List<IResult> results = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    results.Add(logic);
                }
            }
            return null;
        }
    }
}
