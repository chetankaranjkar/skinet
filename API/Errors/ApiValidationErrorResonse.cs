using System.Collections;
using System.Collections.Generic;

namespace API.Errors
{
    public class ApiValidationErrorResonse : ApiResponse
    {
        public ApiValidationErrorResonse() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
        
        
    }
}