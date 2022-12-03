namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public interface ChartStringValue // : System.String
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Index { get ; set; }
  
}
