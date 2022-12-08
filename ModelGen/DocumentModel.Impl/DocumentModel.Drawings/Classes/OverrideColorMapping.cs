namespace DocumentModel.Drawings;

/// <summary>
/// Override Color Mapping.
/// </summary>
public class OverrideColorMappingImpl: DocumentModel.Drawings.ColorMappingType1Impl, OverrideColorMapping
{
  public new DocumentFormat.OpenXml.Drawing.OverrideColorMapping? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OverrideColorMapping?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
