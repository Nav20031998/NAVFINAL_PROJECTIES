using System.Threading.Tasks;
using FINAL_PROJECTCONTACTMANAGER.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace FINAL_PROJECTCONTACTMANAGER.Authorization
{
    public class ContactHRmanagerAuthorizationHandler
                     : AuthorizationHandler<OperationAuthorizationRequirement, Contact>
    {
        protected override Task HandleRequirementAsync(
                                              AuthorizationHandlerContext context,
                                    OperationAuthorizationRequirement requirement,
                                     Contact resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            // If not asking for approval/reject, return.
            if (requirement.Name != Constants.ApproveOperationName &&
                requirement.Name != Constants.RejectOperationName)
            {
                return Task.CompletedTask;
            }

            // HR manager can see the details
            if (context.User.IsInRole(Constants.ContactHRmanagerRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

    }

}
