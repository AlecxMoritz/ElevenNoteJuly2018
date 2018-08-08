﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Elevennote.Web.MVC.Models
{
    public class NoteDetail
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name = "Created At")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified At")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        public override string ToString() => $"[{NoteId}] {Title}";
    }
}