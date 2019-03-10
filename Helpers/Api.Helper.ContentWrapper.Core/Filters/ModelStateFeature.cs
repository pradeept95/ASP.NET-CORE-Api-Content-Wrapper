using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Api.Helper.ContentWrapper.Core.Filters
{
    public class ModelStateFeature
    {
        public ModelStateDictionary ModelState { get; set; }

        public ModelStateFeature(ModelStateDictionary state)
        {
            this.ModelState = state;
        }
    }
}
