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
  
  public TickLabelsImpl(): base() {}
  
  public TickLabelsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
