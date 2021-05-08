using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarAPI.Helpers
{
    public class Response<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string RawData { get; set; }
        public Response(T data, int statusCode, string message, bool success, string rawData = null)
        {
            Data = data;
            StatusCode = statusCode;
            Message = message;
            Success = success;
            RawData = rawData;
        }
    }

    public static class Response
    {
        public static Response<T> Ok<T>(T data, int statusCode = 200, string message = "OK", string rawData = null) =>
            new Response<T>(data, statusCode, message, true, rawData);

        public static Response<T> Fail<T>(string message, int statusCode = 500, T data = default, string rawData = null) =>
            new Response<T>(data, statusCode, message, false, rawData);
    }
}
