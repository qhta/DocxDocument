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
  
  public MinorFontImpl(): base() {}
  
  public MinorFontImpl(DocumentFormat.OpenXml.Drawing.MinorFont openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new TextFontType? LatinFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new TextFontType? EastAsianFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new TextFontType? ComplexScriptFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SupplementalFont>? SupplementalFonts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
