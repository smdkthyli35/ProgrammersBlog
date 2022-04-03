using Core.Utilities.Results.Abstract;
using Entities.ComplexTypes;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Helpers.Abstract
{
    public interface IImageHelper
    {
        string Upload(string Name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
