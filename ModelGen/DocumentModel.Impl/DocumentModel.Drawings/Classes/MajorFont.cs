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
  
  public MajorFontImpl(): base() {}
  
  public MajorFontImpl(DocumentFormat.OpenXml.Drawing.MajorFont openXmlElement): base(openXmlElement)
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
