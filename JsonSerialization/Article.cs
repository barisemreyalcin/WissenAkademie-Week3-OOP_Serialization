using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    [DataContract]
    public class Article
    {
        [DataMember(Name = "Article Id" /*, Order = 1*/)]
        public int ArticleId {  get; set; }
        [DataMember(Name = "Article Name")]
        public string ArticleName {  get; set; }
        [DataMember]
        public string ArticleDescription  {  get; set; }
        [DataMember]
        public List<string> ArticleSiteList { get; set; }
    }
}
