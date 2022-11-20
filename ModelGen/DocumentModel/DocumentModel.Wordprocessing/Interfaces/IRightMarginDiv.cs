namespace DocumentModel.Wordprocessing;

/// <summary>
/// Right Margin for HTML div.
/// </summary>
public interface IRightMarginDiv // : DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType
{
  /// <summary>
  /// Positive or Negative Value in Twentieths of a Point
  /// </summary>
  public string? Val { get ; set; }
  
}
