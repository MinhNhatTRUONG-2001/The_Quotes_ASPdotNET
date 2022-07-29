namespace SharedLib;
public class QuoteDTO
{
    public int Id { get; set; }
    public string Quote { get; set; }
    public string WhoSaid { get; set; }
    public DateTime WhenWasSaid { get; set; }
    public string QuoteCreator { get; set; }
    public string QuoteCreatorNormalized => QuoteCreator.ToUpper();
    public DateTime QuoteCreateDate { get; set; }
}
