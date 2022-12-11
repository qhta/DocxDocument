namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public interface NumericValue
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get ; set; }
  
}
