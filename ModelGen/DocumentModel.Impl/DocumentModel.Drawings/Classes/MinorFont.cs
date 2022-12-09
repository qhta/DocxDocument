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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override TextFontType? EastAsianFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override TextFontType? ComplexScriptFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SupplementalFont>? SupplementalFonts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
