using System;
using System.Collections.Generic;
using System.Text;

namespace mfgrupoCRM.Application.Dto
{
  
    public class SearchResultDto<T>
    {
        public string Query { get; set; }

        public List<T> Results { get; set; }

        public int TotalResults { get; set; }

        public int ResultsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
