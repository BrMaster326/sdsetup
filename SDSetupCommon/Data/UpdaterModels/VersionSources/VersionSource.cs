﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SDSetupCommon.Data.UpdaterModels {
    public interface VersionSource {
        Task<string> GetVersion();
    }
}