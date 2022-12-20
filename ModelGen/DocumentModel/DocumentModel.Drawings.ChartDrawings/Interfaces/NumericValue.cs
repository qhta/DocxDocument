namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public partial interface NumericValue
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }
  
}
