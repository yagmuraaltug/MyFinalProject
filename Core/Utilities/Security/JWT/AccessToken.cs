using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken // Bir kaynağa ulaşmak için verilmiş belirteçtir.
    {
        public string Token { get; set; } //Token : Tek kullanımlık yaşam süresi olan hashlenmiş yada şifrelenmiş bir bilgi içeren metinlerdir.

        public DateTime Expiration { get; set; }
    }
}
