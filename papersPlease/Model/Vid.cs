//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace papersPlease.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vid
    {
        public Vid()
        {
            this.Jurnal = new HashSet<Jurnal>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Jurnal> Jurnal { get; set; }
    }
}