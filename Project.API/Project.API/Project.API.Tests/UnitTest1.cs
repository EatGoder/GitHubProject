﻿using System;
using NUnit.Framework;
using Project.API.ServiceInterface;
using Project.API.ServiceModel;
using ServiceStack.Testing;
using ServiceStack;

namespace Project.API.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(ServiceStackServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
            .Init();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void TestMethod1()
        {
            //var service = appHost.Container.Resolve<ServiceStackServices>();

            //var response = (HelloResponse)service.Any(new Hello { Name = "World" });

            //Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }
    }
}
