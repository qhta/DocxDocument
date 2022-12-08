namespace DocumentModel.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public class MinorFontImpl: DocumentModel.Drawings.FontCollectionTypeImpl, MinorFont
{
  public new DocumentFormat.OpenXml.Drawing.MinorFont? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.MinorFont?)_OpenXmlElement;
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
