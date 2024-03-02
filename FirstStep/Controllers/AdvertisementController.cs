﻿using Azure.Core;
using FirstStep.Models;
using FirstStep.Models.DTOs;
using FirstStep.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstStep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private readonly IAdvertisementService _service;

        public AdvertisementController(IAdvertisementService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllAdvertisements/seekerID={seekerID:int}")]
        public async Task<ActionResult<IEnumerable<AdvertisementShortDto>>> GetAdvertisements(int seekerID)
        {
            var advertisementList = await _service.GetAll(seekerID);
            return advertisementList == null ? NotFound() : Ok(advertisementList);
        }

        [HttpGet]
        [Route("GetAdvertisementById/{jobID:int}")]
        public async Task<ActionResult<AdvertisementDto>> GetAdvertisementById(int jobID)
        {            
            return Ok(await _service.GetById(jobID));
        }

        [HttpGet]
        [Route("GetAdvertisementsByCompanyID/{companyID:int}/filterby={status}")]
        public async Task<ActionResult<IEnumerable<JobOfferDto>>> GetAdvertisementsByCompanyID(int companyID, string status)
        {
            return Ok(await _service.GetAdvertisementsByCompanyID(companyID, status));
        }

        [HttpGet]
        [Route("GetSavedAdvertisements/seekerID={seekerID:int}")]
        public async Task<ActionResult<IEnumerable<AdvertisementShortDto>>> GetSavedAdvertisements(int seekerID)
        {
            return Ok(await _service.GetSavedAdvertisements(seekerID));
        }

        [HttpGet]
        [Route("SearchAdvertisementsBasic")]
        public async Task<ActionResult<IEnumerable<Advertisement>>> SearchAdvertisements([FromQuery] SearchJobRequestDto requestDto)
        {
            return Ok(await _service.BasicSearch(requestDto));
        }

        [HttpPost]
        [Route("AddAdvertisement")]
        public async Task<IActionResult> AddAdvertisement(AddAdvertisementDto advertisementDto)
        {
            await _service.Create(advertisementDto);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateAdvertisement/{jobID:int}")]
        public async Task<IActionResult> UpdateAdvertisement(UpdateAdvertisementDto reqAdvertisement, int jobID)
        {
            if (reqAdvertisement is null)
            {
                return BadRequest("Advertisement cannot be null.");
            }

            if (jobID != reqAdvertisement.advertisement_id)
            {
                return BadRequest("Advertisement ID mismatch.");
            }

            await _service.Update(jobID, reqAdvertisement);
            return Ok();
        }

        [HttpPut]
        [Route("ChangeStatus/{jobID:int}/status={newStatus}")]
        public async Task<IActionResult> ChangeStatus(int jobID, string newStatus)
        {
            await _service.ChangeStatus(jobID, newStatus);
            return Ok();
        }

        [HttpPut]
        [Route("SaveAdvertisement/{advertisementId:int}/seekerId={seekerId:int}")]
        public async Task<IActionResult> SaveAdvertisement(int advertisementId, int seekerId)
        {
            await _service.SaveAdvertisement(advertisementId, seekerId);
            return Ok();
        }

        [HttpPut]
        [Route("UnsaveAdvertisement/{advertisementId:int}/seekerId={seekerId:int}")]
        public async Task<IActionResult> UnsaveAdvertisement(int advertisementId, int seekerId)
        {
            await _service.UnsaveAdvertisement(advertisementId, seekerId);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteAdvertisement/{jobID:int}")]
        public async Task<IActionResult> DeleteAdvertisement(int jobID)
        {
            await _service.Delete(jobID);
            return Ok();
        }
    }
}
