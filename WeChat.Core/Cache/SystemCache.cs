﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Core.Cache
{
    /// <summary>
    /// 基于System.Web.HttpContext.Current.Cache实现的ICache
    /// </summary>
    internal class SystemCache : ICache
    {
        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expire"></param>
        public void Add(string key, object value, DateTime expire)
        {
            System.Web.HttpContext.Current.Cache.Add(key, value, null, expire,
                System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);
        }

        /// <summary>
        /// 移除缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(string key)
        {
            return System.Web.HttpContext.Current.Cache.Get(key);
        }

    }
}
