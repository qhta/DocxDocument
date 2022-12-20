namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public partial interface BevelType
{
  /// <summary>
  /// Width
  /// </summary>
  public Int64? Width { get; set; }
  
  /// <summary>
  /// Height
  /// </summary>
  public Int64? Height { get; set; }
  
  /// <summary>
  /// Preset Bevel
  /// </summary>
  public DocumentModel.Drawings.BevelPresetKind? Preset { get; set; }
  
}
