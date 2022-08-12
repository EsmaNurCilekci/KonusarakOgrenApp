﻿using KonusarakOgren.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.API.Controllers
{
    public class CustombaseController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CustomBaseController : ControllerBase
        {

            [NonAction]
            public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
            {
                if (response.StatusCode == 204)
                    return new ObjectResult(null)
                    {
                        StatusCode = response.StatusCode
                    };

                return new ObjectResult(response)
                {
                    StatusCode = response.StatusCode
                };


            }
        }
    }
}