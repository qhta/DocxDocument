namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public class ValueColorPositionsImpl: ModelElementImpl, ValueColorPositions
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public MinValueColorEndPosition? MinValueColorEndPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get;
    set;
  }
  
}
