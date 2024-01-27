﻿using FirstStep.Data;
using FirstStep.Models;
using FirstStep.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstStep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobFieldController : ControllerBase
    {
        private readonly IJobFieldService _service;

        public JobFieldController(IJobFieldService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllJobFields")]

        public async Task<ActionResult<IEnumerable<JobField>>> GetJobFields()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        [Route("AddJobField")]

        public async Task<ActionResult<JobField>> AddJobField(JobField jobField)
        {
            await _service.Create(jobField);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateJobField")]

        public async Task<IActionResult> UpdateJobField(JobField reqJobField)
        {
            await _service.Update(reqJobField);
            return Ok($"Sucessfully Updated {reqJobField.field_id}");
        }

        [HttpDelete]
        [Route("DeleteJobFieldById/{id}")]

        public async Task<IActionResult> DeleteJobFieldById(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
