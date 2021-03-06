using Business.Extensions;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.ComplexTypes;
using Core.Utilities.Results.Concrete;
using Entities.ComplexTypes;
using Entities.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebUI.Helpers.Abstract;

namespace WebUI.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private const string imgFolder = "img";
        private const string userImagesFolder = "userImages";
        private const string postImagesFolder = "postImages";

        public ImageHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }

        public IDataResult<ImageDeletedDto> Delete(string pictureName)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                var fileInfo = new FileInfo(fileToDelete);
                var imageDeletedDto = new ImageDeletedDto
                {
                    FullName = pictureName,
                    Extension = fileInfo.Extension,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };

                System.IO.File.Delete(fileToDelete);
                return new DataResult<ImageDeletedDto>(ResultStatus.Success, imageDeletedDto);
            }
            else
            {
                return new DataResult<ImageDeletedDto>(ResultStatus.Error, $"Böyle bir resim bulunamadı", null);
            }
        }

        public string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null)
        {
            //Eğer folderName değişkeni null gelir ise, o zaman resim tipine göre (PictureType) klasör adı ataması yapılır.
            folderName ??= pictureType == PictureType.User ? userImagesFolder : postImagesFolder;

            //Eğer folderName değişkeni ile gelen klasör adı sistemimizde mevcut değilse, yeni bir klasör oluşturulur.
            if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
            }

            //Resimin yüklenme sırasındaki ilk adı oldFileName adlı değişkene atanır.
            string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);

            //Resimin uzantısı fileExtension adlı değişkene atanır.
            string fileExtension = Path.GetExtension(pictureFile.FileName);

            Regex regex = new Regex("[*'\",._&#^@]");
            name = regex.Replace(name, string.Empty);


            DateTime dateTime = DateTime.Now;

            //Parametre ile gelen değerler kullanılarak yeni bir resim adı oluşturulur.
            string newFileName = $"{name}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";

            //Kendi parametrelerimiz ile sistemimize uygun yeni bir dosya yolu (path) oluşturulur.
            var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);

            //Sistemimiz için oluşturulan yeni dosya yoluna resim kopyalanır.
            using (var stream = new FileStream(path, FileMode.Create))
            {
                pictureFile.CopyToAsync(stream);
            }

            //Resim tipine göre kullanıcı için bir mesaj oluşturulur.
            string message = pictureType == PictureType.User
                ? $"{name} adlı kullanıcının resmi başarıyla yüklenmiştir."
                : $"{name} adlı makalenin resmi başarıyla yüklenmiştir.";

            return $"{folderName}/{newFileName}";
        }
    }
}
