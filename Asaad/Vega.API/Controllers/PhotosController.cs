using AutoMapper;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Vega.API.Data;
using Vega.API.Helpers;

namespace Vega.API.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/photos")]
    public class PhotosController : Controller
    {
        private readonly IDatingRepository repo;
        private readonly IMapper mapper;
        private readonly IOptions<CloudinarySetting> cloudinaryConfig;
        private Cloudinary cloudinary;

        public PhotosController(IDatingRepository repo, IMapper mapper, IOptions<CloudinarySetting> cloudinaryConfig)
        {
            this.cloudinaryConfig = cloudinaryConfig;
            this.mapper = mapper;
            this.repo = repo;

            Account account = new Account(
                cloudinaryConfig.Value.CloudName,
                cloudinaryConfig.Value.ApiKey,
                cloudinaryConfig.Value.ApiSecret
                 );

            cloudinary = new Cloudinary(account);
        }
    }
}