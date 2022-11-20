namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blur Class.
/// </summary>
public interface IBlur // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Radius
  /// </summary>
  public long? Radius { get ; set; }
  
  /// <summary>
  /// Grow Bounds
  /// </summary>
  public bool? Grow { get ; set; }
  
}
