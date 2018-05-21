using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Abp.Auditing;
//using JiraDashboard.Sessions.Dto;
//using Abp.Application.Services.Dto;
using JiraDashboard.JiraFeatures.Dto;
//using JiraDashboard.SignalR;
using Newtonsoft.Json;
using System.Text;

namespace JiraDashboard.JiraFeatures
{
    public class JiraFeatureAppService : JiraDashboardAppServiceBase, IJiraFeatureAppService
    {

        HttpClient client = new HttpClient();

        public JiraFeatureAppService()
        {
            var byteArray = Encoding.ASCII.GetBytes("rajatt.chugh@gmail.com:love2jira~");

            client.BaseAddress = new Uri("http://sample-ira.atlassian.net/rest/agile/1.0/board/1/backlog");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",Convert.ToBase64String(byteArray));
        }
       
        [DisableAuditing]
        public async Task<Backlog> GetAll()
        {
            HttpResponseMessage responseMessage = await client.GetAsync("");

            if (responseMessage.IsSuccessStatusCode)
            {
                var stringResult = await responseMessage.Content.ReadAsStringAsync();
                Backlog backlog  = JsonConvert.DeserializeObject<Backlog>(stringResult);
                return backlog;
            }
            return new Backlog();
        }

  /*      public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                Application = new ApplicationInfoDto
                {
                    Version = AppVersionHelper.Version,
                    ReleaseDate = AppVersionHelper.ReleaseDate,
                    Features = new Dictionary<string, bool>
                    {
                        { "SignalR", SignalRFeature.IsAvailable },
                        { "SignalR.AspNetCore", SignalRFeature.IsAspNetCore }
                    }
                }
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            if (AbpSession.UserId.HasValue)
            {
                output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            return output;
        }*/
    }
}
