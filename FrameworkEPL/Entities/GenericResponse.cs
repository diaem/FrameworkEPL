using System;
namespace FrameworkEPL.Entities
{
    public enum ResponseCode
    {
        OK                = 200,
        OK_VOID           = 204,
        INVALID_ARGUMENTS = 301,
        INVALID_DATA      = 400,
        INTERNAL_ERROR    = 500,
        DATABASEERROR     = 510,
        NOFOUNDDATA       = 410,
    }

    public class GenericResponse
    {
        public int          IdResponse { get; set; }
        public string       Message    { get; set; }
        public ResponseCode Code       { get; set; }
        public string       Value      { get; set; }
    }
}

