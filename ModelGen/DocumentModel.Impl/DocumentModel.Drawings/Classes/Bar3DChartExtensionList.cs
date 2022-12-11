namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public class Bar3DChartExtensionListImpl: ModelElementImpl, Bar3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Bar3DChartExtensionListImpl(): base() {}
  
  public Bar3DChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Bar3DChartExtension>? Bar3DChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
