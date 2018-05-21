using System;
using Abp.Application.Services.Dto;

namespace JiraDashboard.JiraFeatures.Dto
{
    public class Backlog 
    {
        public string Expand { get; set; }

        public int StartAt { get; set; }

        public int MaxResults { get; set; }

        public int Total { get; set; }

        public JiraFeatureDto[] Issues { get; set; }

    }



}
