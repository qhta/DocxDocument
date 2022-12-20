namespace DocxDocument.Model;

public class LangText
{
  public string? Lang { get; set; }
  public string? Text { get; set; }

  public bool IsEmpty => Lang == null || Text == null;
}