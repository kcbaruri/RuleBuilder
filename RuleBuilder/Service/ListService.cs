using Common;
using Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace Service
{
    public interface IListService
    {
        List<DataListItem> GetEnumItems<T>();
    }

    public class ListService : IListService
    {
        [Dependency]
        public IParameterService ParameterService { get; set; }

        [Dependency]
        public IRulesService RulesService { get; set; }

        public List<DataListItem> GetEnumItems<T>()
        {
            var valueList = Enum.GetValues(typeof(T)).Cast<T>();

            var intermediateList = valueList
                .Where(x => !x.HasAttribute<ListIgnoreAttribute>())
                .Select(x => new DataListItem
                {
                    Value = x.ToString(),
                    Text = x.GetDescription()
                })
                .ToList();

            return intermediateList;
        }
    }
}
