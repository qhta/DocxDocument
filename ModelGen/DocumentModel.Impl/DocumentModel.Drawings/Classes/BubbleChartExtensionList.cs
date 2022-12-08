namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public class BubbleChartExtensionListImpl: ModelElementImpl, BubbleChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<BubbleChartExtension>? BubbleChartExtensions
  {
    get;
    set;
  }
  
}
