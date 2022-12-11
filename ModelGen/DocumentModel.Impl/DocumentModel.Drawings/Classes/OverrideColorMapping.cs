namespace DocumentModel.Drawings;

/// <summary>
/// Override Color Mapping.
/// </summary>
public class OverrideColorMappingImpl: DocumentModel.Drawings.ColorMappingTypeImpl, OverrideColorMapping
{
  public new DocumentFormat.OpenXml.Drawing.OverrideColorMapping? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OverrideColorMapping?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OverrideColorMappingImpl(): base() {}
  
  public OverrideColorMappingImpl(DocumentFormat.OpenXml.Drawing.OverrideColorMapping openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
