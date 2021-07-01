using System;
using Labo2ASPdotNet.Wrappers.Filters;

namespace Labo2ASPdotNet.Services
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
