namespace DocumentModel.Interop;

/// <summary>
/// Contains properties and methods that apply to WordArt objects.
/// </summary>
public partial interface TextEffectFormat : InteropObject
{
  /// <summary>
  /// The alignment.
  /// </summary>
  //public Core.MsoTextEffectAlignment Alignment { get; set; }

  /// <summary>
  /// The font bold.
  /// </summary>
  //public Core.MsoTriState FontBold { get; set; }

  /// <summary>
  /// The font italic.
  /// </summary>
  //public Core.MsoTriState FontItalic { get; set; }

  /// <summary>
  /// The font name.
  /// </summary>
  public string FontName { get; set; }

  /// <summary>
  /// The font size.
  /// </summary>
  public float FontSize { get; set; }

  /// <summary>
  /// The kerned pairs.
  /// </summary>
  //public Core.MsoTriState KernedPairs { get; set; }

  /// <summary>
  /// The normalized height.
  /// </summary>
  //public Core.MsoTriState NormalizedHeight { get; set; }

  /// <summary>
  /// The preset shape.
  /// </summary>
  //public Core.MsoPresetTextEffectShape PresetShape { get; set; }

  /// <summary>
  /// The preset text effect.
  /// </summary>
  //public Core.MsoPresetTextEffect PresetTextEffect { get; set; }

  /// <summary>
  /// The rotated chars.
  /// </summary>
  //public Core.MsoTriState RotatedChars { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The tracking.
  /// </summary>
  public float Tracking { get; set; }
}
