using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_MVC_Workshop2.Models
{
    public class BookSearchArg
    {
        public string BOOK_ID { get; set; }
        [DisplayName("圖書類別")]
        [Required()]
        public string BOOK_CLASS_ID { get; set; }
        [DisplayName("書籍名稱")]
        [Required()]
        public string BOOK_NAME { get; set; }
        [DisplayName("購書日期")]
        [Required()]
        public string BOOK_STATUS { get; set; }
        [DisplayName("借閱人")]
        [Required()]
        public string BOOK_BOUGHT_DATE { get; set; }
        [DisplayName("借閱狀態")]
        [Required()]
        public string BOOK_KEEPER { get; set; }
        [DisplayName("作者")]
        [Required()]
        public string BOOK_AUTHOR { get; set; }
        [DisplayName("出版社")]
        [Required()]
        public string BOOK_PUBLISHER { get; set; }
        [DisplayName("內容簡介")]
        [Required()]
        public string BOOK_NOTE { get; set; }

    }
}