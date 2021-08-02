﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SDSetupCommon;
using SDSetupCommon.Data;
using SDSetupCommon.Data.BundlerModels;

namespace SDSetupBackend.Controllers.v2 {
    [ApiController]
    [Route("api/v2/files")]
    public class FilesController : ControllerBase {

        private readonly ILogger<GeneralController> _logger;

        public FilesController(ILogger<GeneralController> logger) {
            _logger = logger;
        }

        [HttpGet("latestpackageset")]
        public async Task<IActionResult> LatestPackageSet() {
            return new ObjectResult(Program.ActiveConfig.LatestPackageset);
        }

        [HttpGet("manifest/{packageset}")]
        public async Task<IActionResult> Manifest(string packageset) {
            if (Program.ActiveRuntime.Manifests.ContainsKey(packageset)) return new JsonResult(Program.ActiveRuntime.Manifests[packageset]);
            else return new StatusCodeResult(404);
        }

        [HttpPost("requestbundle")]
        public async Task<IActionResult> RequestBundle([FromBody] BundleRequestModel model) {
            string packageset = model.packageset;
            string[] packages = model.packages;
            string uuid = Utilities.CreateCryptographicallySecureGuid().ToCleanString();

            //TODO: implement queue
            _ = Task.Run(() => {
                Program.ActiveRuntime.BuildBundle(uuid, packageset, packages);
            });

            return this.StatusCode(202, uuid); //accepted
        }

        [HttpGet("bundleprogress/{uuid}")]
        public async Task<IActionResult> BundleProgress(string uuid) {
            BundlerProgress progress = Program.ActiveRuntime.GetBundlerProgress(uuid);
            return new ObjectResult(progress);
        }
    }
}
