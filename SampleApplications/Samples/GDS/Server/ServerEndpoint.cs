//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opc.Ua.Gds.Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServerEndpoint
    {
        public int ID { get; set; }
        public int ApplicationId { get; set; }
        public string DiscoveryUrl { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
