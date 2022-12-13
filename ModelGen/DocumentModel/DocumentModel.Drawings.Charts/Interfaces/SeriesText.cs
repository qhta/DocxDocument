namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public interface SeriesText
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference { get ; set; }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public String? NumericValue { get ; set; }
  
}
