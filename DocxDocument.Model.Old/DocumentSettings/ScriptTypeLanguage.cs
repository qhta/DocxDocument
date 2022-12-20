namespace DocxDocument.Model;

public class ScriptTypeLanguage : DocxBasedElement<WD.ThemeFontLanguages>, IScriptTypeLanguage
{

  public ScriptTypeLanguage() : base(new WD.ThemeFontLanguages())
  {
  }

  public ScriptTypeLanguage(WD.ThemeFontLanguages element) : base(element)
  {
  }

  [XmlAttribute]
  public string? Default
  {
    get => DocxElement.Val?.Value;
    set => DocxElement.Val = value;
  }

  [XmlAttribute]
  public string? Bidi
  {
    get => DocxElement.Bidi?.Value;
    set => DocxElement.Bidi = value;
  }

  [XmlAttribute]
  public string? EastAsia
  {
    get => DocxElement.EastAsia?.Value;
    set => DocxElement.EastAsia = value;
  }
}