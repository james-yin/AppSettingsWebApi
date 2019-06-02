using System.Collections.Generic;
using AppSettingsWebApi.Controllers;
using AppSettingsWebApi.Models;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace AppSettingsWebApi.Tests
{
    [TestFixture]
    public class ValuesControllerShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnFileUploadSettings()
        {
            var settings = new FileUploadSettings()
            {
                FileSizeLimitInMB = 123,
                FileTypesAllowed = "pizza|grape",
                FileTypesAllowedList = new List<string>() { "pizza", "grape" }
            };
            IOptions<FileUploadSettings> settingOptions = Options.Create(settings);

            var sut = new ValuesController(settingOptions);
            var result = sut.Get();

            var okResult = result as OkObjectResult;
            Assert.That(okResult.Value, Is.TypeOf<FileUploadSettings>());
        }
    }
}