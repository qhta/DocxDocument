namespace DocumentModel.Wordprocessing;

/// <summary>
/// Hyphenation Zone.
/// </summary>
public interface IHyphenationZone // : DocumentFormat.OpenXml.Wordprocessing.TwipsMeasureType
{
  /// <summary>
  /// Measurement in Twentieths of a Point
  /// </summary>
  public string? Val { get ; set; }
  
}
