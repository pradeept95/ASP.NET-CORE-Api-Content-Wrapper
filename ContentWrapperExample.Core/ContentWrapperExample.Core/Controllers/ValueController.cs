using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api.ResultWrapper.AspNetCore.BaseApiController;
using Api.ResultWrapper.AspNetCore.Extensions;
using Api.ResultWrapper.AspNetCore.ResponseModel;
using Api.ResultWrapper.AspNetCore.WrapperModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentWrapperExample.Core.Controllers
{ 
    public class ValueController : BaseApiController
    {
        [Route("get")]
        [HttpGet]
        public ListResultDto<string> Get()
        {
            var result = new List<string>();
            result.Add("date 1");
            result.Add("date 2");
            result.Add("date 3");
            result.Add("date 4");
            result.Add("date 5");
            result.Add("date 6");
            result.Add("date 7"); 
            return new ListResultDto<string>(result);
        }


        [Route("excExample")]
        [HttpGet]
        public List<string> GetExcResult()
        { 
            var result = new List<string>();
            result.Add("date 1");
            result.Add("date 2");
            result.Add("date 3");
            result.Add("date 4");
            result.Add("date 5");
            result.Add("date 6");
            result.Add("date 7");
            return result;
        }

        [Route("save")]
        [HttpPost] 
        public ResultDto<PostModel> PostExample(PostModel model)
        { 
            return new ResultDto<PostModel>(model);
        }


        [Route("saveandGetList")]
        [HttpPost]
        public ListResultDto<PostModel> PostAngGetListExample(PostModel model)
        { 
            var result = new List<PostModel>();
            result.Add(model);
            result.Add(model);
            result.Add(model);
             
            return new ListResultDto<PostModel>(result);
        }

        [Route("saveandGetListWithPage")]
        [HttpPost]
        public PagedResultDto<PostModel> PostAngGetListWithPageExample(PostModel model)
        {
            var result = new List<PostModel>();
            result.Add(model);
            result.Add(model);
            result.Add(model);

            var totalCount = result.Count();
            return new PagedResultDto<PostModel>(totalCount, result);
        } 
    }

    public class PostModel
    {
        public long Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage ="Min Length is 5.")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}