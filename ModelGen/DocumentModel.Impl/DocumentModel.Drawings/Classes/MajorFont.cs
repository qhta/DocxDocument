namespace DocumentModel.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public class MajorFontImpl: DocumentModel.Drawings.FontCollectionTypeImpl, MajorFont
{
  public new DocumentFormat.OpenXml.Drawing.MajorFont? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.MajorFont?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override TextFontType? LatinFont
  {
    get;
    set;
  }
  
  public override TextFontType? EastAsianFont
  {
    get;
    set;
  }
  
  public override TextFontType? ComplexScriptFont
  {
    get;
    set;
  }
  
  public Collection<SupplementalFont>? SupplementalFonts
  {
    get;
    set;
  }
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
