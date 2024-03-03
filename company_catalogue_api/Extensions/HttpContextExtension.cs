using System;
namespace company_catalogue_api.Extensions
{
	public static class HttpContextExtension
	{
		public static int GetUserId(this HttpContext httpContext)
		{
			return httpContext.Items["UserId"] as int? ??
				throw new Exception("User ID not found in HttpContext.Items");
		}
	}
}

