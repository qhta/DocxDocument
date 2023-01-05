namespace DocumentModel;

public record StringNum()
{
  [XmlAttribute]
  public string? Str { get; set; }
  [XmlAttribute]
  public int? Num { get; set; }
}