﻿using Application.Features.ProgramLaunge.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgramLaunge.Models
{
    public class LanguageListModel : BasePageableModel
    {
        public IList<LanguageListDto> Items { get; set; }
    }
}
