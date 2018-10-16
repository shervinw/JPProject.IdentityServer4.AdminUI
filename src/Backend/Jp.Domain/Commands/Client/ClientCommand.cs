using System;
using Jp.Domain.Core.Commands;

namespace Jp.Domain.Commands.Client
{
    public abstract class ClientCommand : Command
    {
        public IdentityServer4.Models.Client Client { get; set; }
        public string OldClientId { get; set; }
    }
}