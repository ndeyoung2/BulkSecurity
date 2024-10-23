using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;

namespace BulkSecurity
{
    internal class SystemUserControl
    {
        private readonly IOrganizationService service;

        public SystemUserControl(IOrganizationService service)
        {
            this.service = service;
        }

        public Guid GetCurrentUserId()
        {
            return ((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId;
        }
    }
}