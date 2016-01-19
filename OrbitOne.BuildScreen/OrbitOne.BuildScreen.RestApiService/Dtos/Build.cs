using System;

namespace OrbitOne.BuildScreen.Models
{
    public class Build
    {
        private RequestedFor _requestedFor;

        public Build()
        {
            RequestedFor = new RequestedFor();
        }

        public DateTime FinishTime { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public RequestedFor RequestedFor
        {
            get { return _requestedFor; }
            set
            {
                if (value == null)
                    _requestedFor = new RequestedFor();
                else
                    _requestedFor = value;
            }
        }

        public Request[] Requests { get; set; }
        public string Uri { get; set; }
        public Definition Definition { get; set; }
    }

    public class Definition
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class RequestedFor
    {
        public RequestedFor()
        {
            DisplayName = "Anonymous";
            ImageUrl = string.Empty;
        }

        public string DisplayName
        { get; set; }
        public string ImageUrl
        { get; set; }
    }

    public class Request
    {
        public RequestedFor RequestedFor { get; set; }
    }
}