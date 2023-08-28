using Entities.DataTransferObjects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contract
{
    public interface IBookLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto, string fields, HttpContext httpContext);
    }
}
