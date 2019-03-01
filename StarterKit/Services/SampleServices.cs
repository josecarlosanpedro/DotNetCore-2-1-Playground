using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using StarterKit.Models;

namespace StarterKit.Services
{
    public class SampleServices : ISampleServices
    {
        private readonly Dictionary<string, SampleItemModel> _sampleItem;

        public SampleServices()
        {
            _sampleItem = new Dictionary<string, SampleItemModel>();
        }
        public SampleItemModel AddSampleItems(SampleItemModel items)
        {
            _sampleItem.Add(items.SampleName, items);
            return items;
            //throw new System.NotFiniteNumberException();
        }

        public Dictionary<string, SampleItemModel> GetSampleItems()
        {
            return _sampleItem;
        }
    }
}
