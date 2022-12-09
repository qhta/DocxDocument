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
