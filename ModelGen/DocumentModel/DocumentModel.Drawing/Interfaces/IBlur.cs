namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public interface IBlur // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius { get ; set; }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public Boolean? Grow { get ; set; }
  
}
