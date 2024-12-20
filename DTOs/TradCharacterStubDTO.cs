namespace ccex_api.DTOs;

public class TradCharacterStubDTO
{
  public int Id { get; set; }
  public string Char { get; set; } = string.Empty;
  public ICollection<string> Pinyin { get; set; } = [];
  public string? Definition { get; set; } = null;
  public string? Description { get; set; } = null;

}