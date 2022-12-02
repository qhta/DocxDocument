namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public interface IBevelType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Width
  /// </summary>
  public Int64? Width { get ; set; }
  
  /// <summary>
  /// Height
  /// </summary>
  public Int64? Height { get ; set; }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public BevelPresetKind? Preset { get ; set; }
  
}
