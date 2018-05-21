using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using JiraDashboard.Authorization.Users;

namespace JiraDashboard.JiraFeatures.Dto
{
    public class JiraFeatureDto
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public Fields Fields { get; set; }

    }
}
