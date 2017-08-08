﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using Powel.AzureTableStorage.IdentityServer4.Mappers;
using IdentityServer4.Models;
using Xunit;

namespace Powel.AzureTableStorage.IdentityServer4.UnitTests.Mappers
{
    public class ScopesMappersTests
    {
        [Fact]
        public void IdentityResourceAutomapperConfigurationIsValid()
        {
            var model = new IdentityResource();
            var mappedEntity = model.ToEntity();
            var mappedModel = mappedEntity.ToModel();

            Assert.NotNull(mappedModel);
            Assert.NotNull(mappedEntity);
            IdentityResourceMappers.Mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [Fact]
        public void ApiResourceAutomapperConfigurationIsValid()
        {
            var model = new ApiResource();
            var mappedEntity = model.ToEntity();
            var mappedModel = mappedEntity.ToModel();

            Assert.NotNull(mappedModel);
            Assert.NotNull(mappedEntity);
            ApiResourceMappers.Mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}