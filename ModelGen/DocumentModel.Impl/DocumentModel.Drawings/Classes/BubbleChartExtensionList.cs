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
  
  public BubbleChartExtensionListImpl(): base() {}
  
  public BubbleChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<BubbleChartExtension>? BubbleChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
