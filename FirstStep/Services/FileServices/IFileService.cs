﻿using Azure.Storage.Blobs.Models;

namespace FirstStep.Services
{
    public interface IFileService
    {
        public Task<List<string>> UploadFiles(List<IFormFile> files);
        public Task<string> UploadFileWithApplication(IFormFile file);
        public Task<List<BlobItem>> GetUploadedBlobs();
        public Task<string> GenerateSasTokenAsync( string blobName);
        public Task<string> GetBlobImageUrl(string blobName);
    }
}
