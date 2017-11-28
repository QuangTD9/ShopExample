using System;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyWord { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}