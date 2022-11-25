namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public interface IBlur // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Radius
  /// </summary>
  public System.Int64? Radius { get ; set; }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public System.Boolean? Grow { get ; set; }
  
}
