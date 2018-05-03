﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JobChart.Models;

namespace JobChart.Services.Interface
{
    public interface IPolarService
    {
        Task<IList<PolarModel>> Get();
    }
}
