﻿using BelissimoCloneWPF.Domain.Entities.Attachment;
using BelissimoCloneWPF.Domain.Entities.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelissimoCloneWPF.Service.DTOs.Foods
{
    public class FoodForViewDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int AttachmentsId { get; set; }
        public Attachments Attachment { get; set; }
    }
}
