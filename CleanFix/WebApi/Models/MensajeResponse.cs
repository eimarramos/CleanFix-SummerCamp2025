﻿namespace WebApi.Models
{
    public class MensajeResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }
    }
}
