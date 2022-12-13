namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public interface ValueColorPositions
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
