using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }
}
