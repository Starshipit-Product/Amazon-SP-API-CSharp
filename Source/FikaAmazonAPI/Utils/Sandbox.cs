﻿using FikaAmazonAPI.Parameter;
using FikaAmazonAPI.Parameter.ListingsItems;
using FikaAmazonAPI.Parameter.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.Utils
{
    internal static class Sandbox
    {
        public static Dictionary<string, List<KeyValuePair<string, string>>> SandboxQueryParameters<T>(string testCase) where T : IHasParameterizedTestCase
        {
            var queryParameters = new Dictionary<string, List<KeyValuePair<string, string>>>();
            if (typeof(T) == typeof(ParameterOrderList))
            {
                if (testCase.Equals(Constants.TestCase200))
                {
                    queryParameters.Add(Constants.TestCase200, new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("CreatedAfter", Constants.TestCase200),
                        new KeyValuePair<string, string>("MarketplaceIds", MarketPlace.US.ID)
                    });
                }
            }
            else if (typeof(T) == typeof(ParameterGetListingsItem))
            {
                if (testCase.Equals(Constants.TestCase200))
                {

                }
            }

            return queryParameters;
        }
    }
}
