namespace DocumentModel.Drawings;

/// <summary>
///   Defines the BevelType interface.
/// </summary>
public interface BevelType: IModelElement
{
  /// <summary>
  ///   Width
  /// </summary>
  public Int64? Width { get; set; }
  /// <summary>
  ///   Height
  /// </summary>
  public Int64? Height { get; set; }
  /// <summary>
  ///   Preset Bevel
  /// </summary>
  public BevelPresetKind? Preset { get; set; }
}