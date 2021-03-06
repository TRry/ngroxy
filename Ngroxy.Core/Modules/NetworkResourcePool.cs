﻿#region summary
//   ------------------------------------------------------------------------------------------------
//   <copyright file="NetworkResourcePool.cs">
//     用户：朱宏飞
//     日期：2017/03/04
//     时间：11:02
//   </copyright>
//   ------------------------------------------------------------------------------------------------
#endregion

namespace Ngroxy.Modules
{
    using System.Collections.Generic;

    public class NetworkResourcePool
    {
        public string Name { get; set; }
        public User Owner { get; set; }
        public ICollection<NetworkResource> NetworkResources { get; set; }
    }
}