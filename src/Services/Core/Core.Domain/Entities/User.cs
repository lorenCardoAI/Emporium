using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Models
{
    public class User
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastLogin { get; set; }
        public DateTime? DateLastActivity { get; set; }
        public DateTime DateLastPasswordChange { get; set; }
        public long UserId { get; set; }
        public string Token { get; set; }
        public bool Mailing_List { get; set; }
        public bool Iscritto_a_PRO { get; set; }
        public int Giorni_residui_BP { get; set; }
        public int Giorni_residui_AG { get; set; }
        public int Codice_Cliente { get; set; }
        public bool Salvata_Nel_Centralino { get; set; }
        public long Id_Operatore { get; set; }
        public string Nickname { get; set; }
        public bool IsLegaleRappresentante { get; set; }
        public bool RemarketingList { get; set; }
        public int? OriginId { get; set; }
        public virtual Origin Origin { get; set; }
    }
}
