namespace DocxDocument.Model;

public class StyleRef
{
  [XmlText]
  public string? StyleID { get; set; }

  [XmlIgnore]
  [JsonIgnore]
  public IStyle? Style { get; set; }

}