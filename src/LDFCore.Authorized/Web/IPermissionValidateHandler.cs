﻿using LDFCore.Common.Enums;
using System.Collections.Generic;

namespace LDFCore.Authorized.Web
{
    /// <summary>
    /// 权限验证处理接口
    /// </summary>
    public interface IPermissionValidateHandler
    {
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        bool Validate(IDictionary<string, string> routeValues, HttpMethod httpMethod);
    }
}
