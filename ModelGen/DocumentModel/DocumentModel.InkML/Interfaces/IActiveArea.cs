namespace DocumentModel.InkML;

/// <summary>
/// Defines the ActiveArea Class.
/// </summary>
public interface IActiveArea // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// size
  /// </summary>
  public String? Size { get ; set; }
  
  /// <summary>
  /// height
  /// </summary>
  public Decimal? Height { get ; set; }
  
  /// <summary>
  /// width
  /// </summary>
  public Decimal? Width { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public String? Units { get ; set; }
  
}
