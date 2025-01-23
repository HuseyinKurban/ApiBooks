namespace ApiBooks.WebUI.Areas.Admin.Dto.FeatureDto
{
    public class ResultFeatureDto
    {
        public int FeatureId { get; set; }

        public string BookName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string WriterNameSurname { get; set; }

        public decimal BookPrice { get; set; }
    }
}
