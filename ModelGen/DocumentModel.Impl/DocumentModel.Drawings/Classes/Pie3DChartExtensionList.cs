namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public class Pie3DChartExtensionListImpl: ModelElementImpl, Pie3DChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Pie3DChartExtension>? Pie3DChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
