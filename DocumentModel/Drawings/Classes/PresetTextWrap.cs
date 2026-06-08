namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Preset Text Warp.
/// </summary>
public class PresetTextWrap: ModelElement
{
  /// <summary>
  ///   Preset Warp IShape
  /// </summary>
  public TextShapeKind? Preset { get; set; }

  /// <summary>
  ///   Adjust Value IList.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }
}
