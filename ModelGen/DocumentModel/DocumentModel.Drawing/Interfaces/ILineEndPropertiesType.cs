namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public interface ILineEndPropertiesType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public LineEndValues? Type { get ; set; }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public LineEndWidthValues? Width { get ; set; }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public LineEndLengthValues? Length { get ; set; }
  
}
