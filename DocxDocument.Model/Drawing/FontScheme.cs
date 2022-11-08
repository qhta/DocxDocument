namespace DocxDocument.Model.Drawing;

public class FontScheme: ThemeElement
{
  [XmlAttribute]
  public string? Name { get; set;}
  
  /// <summary>
  /// Font collection best suited for heading text.
  /// </summary>
  public FontCollection? MajorFont { get; set; }

  /// <summary>
  /// Font collection best suited for normal text.
  /// </summary>
  public FontCollection? MinorFont { get; set; }
}