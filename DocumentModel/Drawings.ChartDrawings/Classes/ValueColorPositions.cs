namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public class ValueColorPositions: ModelElement
{
  /// <summary>
  ///   count, this property is only available in Office 2016 and later.
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