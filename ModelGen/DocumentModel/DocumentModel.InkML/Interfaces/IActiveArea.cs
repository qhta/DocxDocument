namespace DocumentModel.InkML;

/// <summary>
/// Defines the ActiveArea Class.
/// </summary>
public interface IActiveArea // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// size
  /// </summary>
  public System.String? Size { get ; set; }
  
  /// <summary>
  /// height
  /// </summary>
  public System.Decimal? Height { get ; set; }
  
  /// <summary>
  /// width
  /// </summary>
  public System.Decimal? Width { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public System.String? Units { get ; set; }
  
}
