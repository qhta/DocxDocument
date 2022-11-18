namespace DocumentModel.InkML;

/// <summary>
/// Defines the ActiveArea Class.
/// </summary>
public interface IActiveArea // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// size
  /// </summary>
  public string? Size { get ; set; }
  
  /// <summary>
  /// height
  /// </summary>
  public decimal? Height { get ; set; }
  
  /// <summary>
  /// width
  /// </summary>
  public decimal? Width { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public string? Units { get ; set; }
  
}
