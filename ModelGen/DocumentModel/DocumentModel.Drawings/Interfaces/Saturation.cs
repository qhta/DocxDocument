namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public interface Saturation // : System.Boolean
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount { get ; set; }
  
}
