namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public class BubbleChartExtensionImpl: ModelElementImpl, BubbleChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredBubbleSeries? FilteredBubbleSeries
  {
    get;
    set;
  }
  
}
