namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public interface ValueColorPositions:
{
  /// <summary>
  ///   count
  /// </summary>
  public Int32? Count { get; set; }
  /// <summary>
  ///   MinValueColorEndPosition.
  /// </summary>
  public MinValueColorEndPosition? MinValueColorEndPosition { get; set; }
  /// <summary>
  ///   ValueColorMiddlePosition.
  /// </summary>
  public ValueColorMiddlePosition? ValueColorMiddlePosition { get; set; }
  /// <summary>
  ///   MaxValueColorEndPosition.
  /// </summary>
  public MaxValueColorEndPosition? MaxValueColorEndPosition { get; set; }
}