namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public class ValueColorPositionsImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>, ValueColorPositions
{
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
