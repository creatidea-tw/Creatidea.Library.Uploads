﻿using System.ComponentModel;

namespace Ci.Upload.Enums
{
    public enum StorageType
    {
        [Description("本地端")]
        Local = 1,

        [Description("Imgur圖床")]
        Imgur = 2,
        Azure = 3,
        S3 = 4
    }
}
