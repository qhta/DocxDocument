namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TickLabels Class.
/// </summary>
public class TickLabelsImpl: ModelElementImpl, TickLabels
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
