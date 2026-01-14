namespace DocumentModel.Drawings;

/// <summary>
///   Represents a preset text wrap, including the wrap shape and optional adjustment values.
/// </summary>
public interface PresetTextWrap
{
  /// <summary>
  ///   Preset wrap shape for the text wrap.
  /// </summary>
  public TextShapeKind? Preset { get; set; }

  /// <summary>
  ///   List of adjustment values for the preset text wrap.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }
}