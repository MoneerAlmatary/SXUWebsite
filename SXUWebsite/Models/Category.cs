namespace SXUWebsite.Models
{
    public class Category
    {

        public int CategoryID { get; set; }
        public string CatName { get; set; }   
        public List<ListedCom>? listedComs { get; set; }
    }
}
