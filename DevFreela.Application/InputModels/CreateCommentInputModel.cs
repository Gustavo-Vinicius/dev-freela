using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}