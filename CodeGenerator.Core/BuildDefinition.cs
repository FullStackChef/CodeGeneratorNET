﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Core
{
    public class BuildDefinition
    {
        public string Resource { get; set; }
        public IEnumerable<TemplateItem> Templates { get; set; }
        public string TemplatesDefinition { get; set; }
        public string TemplateDirectory { get; set; }
        public IEnumerable<ClassModel> Models { get; set; }
        public string ModelsDefinition { get; set; }
    }
}
