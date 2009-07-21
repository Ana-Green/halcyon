using System;

namespace HttpServer.MVC.Controllers
{
    /// <summary>
    /// This attribute tells the controller that the method
    /// uses SendHeader and/or SendBody to handle the request.
    /// </summary>
    public class RawHandlerAttribute : Attribute
    {
    }
}
