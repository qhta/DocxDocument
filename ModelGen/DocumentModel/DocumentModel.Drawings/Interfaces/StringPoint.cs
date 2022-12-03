namespace DocumentModel.Drawings;

/// <summary>
/// String Point.
/// </summary>
public interface StringPoint // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public String? NumericValue { get ; set; }
  
}
