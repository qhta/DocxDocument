namespace DocumentModel.Drawings;

/// <summary>
/// Series Text.
/// </summary>
public interface SeriesText // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference { get ; set; }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public String? NumericValue { get ; set; }
  
}
