using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarterKit.Models;

namespace StarterKit.Services
{
    public interface ISampleServices
    {
        SampleItemModel AddSampleItems(SampleItemModel items);
        Dictionary<string, SampleItemModel> GetSampleItems();
    }
}
