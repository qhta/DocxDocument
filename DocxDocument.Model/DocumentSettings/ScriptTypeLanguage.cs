namespace DocxDocument.Model;

public class ScriptTypeLanguage: IScriptTypeLanguage
{
  [XmlAttribute]
  public string? Default { get; set;}

  [XmlAttribute]
  public string? Bidi { get; set; }

  [XmlAttribute]
  public string? EastAsia { get; set; }
}