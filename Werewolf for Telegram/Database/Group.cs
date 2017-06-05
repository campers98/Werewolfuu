//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Games = new HashSet<Game>();
            this.Players = new HashSet<Player>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public long GroupId { get; set; }
        public Nullable<bool> Preferred { get; set; }
        public string Language { get; set; }
        public Nullable<bool> DisableNotification { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> BotInGroup { get; set; }
        public Nullable<bool> ShowRoles { get; set; }
        public string Mode { get; set; }
        public Nullable<int> DayTime { get; set; }
        public Nullable<int> NightTime { get; set; }
        public Nullable<int> LynchTime { get; set; }
        public Nullable<bool> AllowTanner { get; set; }
        public Nullable<bool> AllowFool { get; set; }
        public Nullable<bool> AllowCult { get; set; }
        public string ShowRolesEnd { get; set; }
        public Nullable<int> MaxPlayers { get; set; }
        public Nullable<bool> DisableFlee { get; set; }
        public string CreatedBy { get; set; }
        public string ImageFile { get; set; }
        public string Description { get; set; }
        public string GroupLink { get; set; }
        public Nullable<int> MemberCount { get; set; }
        public Nullable<bool> AllowExtend { get; set; }
        public Nullable<int> MaxExtend { get; set; }
        public Nullable<bool> EnableSecretLynch { get; set; }
        public Nullable<long> Flags { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game> Games { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
    }
}
