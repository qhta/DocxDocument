namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public class ValueColorMiddlePositionImpl: ModelElementImpl, ValueColorMiddlePosition
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition
  {
    get;
    set;
  }
  
}
