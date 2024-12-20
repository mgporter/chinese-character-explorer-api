namespace ccex_api.Aggregates;

public class TradCharacterStub
{
  public string Char { get; set; } = string.Empty;
  public ICollection<string> Pinyin { get; set; } = [];
  public string? Definition { get; set; } = null;
  public string? Description { get; set; } = null;

}