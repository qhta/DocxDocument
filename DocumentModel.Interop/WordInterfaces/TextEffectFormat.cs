namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to WordArt objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat?view=word-pia"/>
public partial interface TextEffectFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.alignment?view=word-pia"/>
  public Core.MsoTextEffectAlignment Alignment { get; set; }

  /// <summary>
  /// Returns or sets whether font bold.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontbold?view=word-pia"/>
  public Core.MsoTriState FontBold { get; set; }

  /// <summary>
  /// Returns or sets whether font italic.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontitalic?view=word-pia"/>
  public Core.MsoTriState FontItalic { get; set; }

  /// <summary>
  /// Returns or sets the font name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontname?view=word-pia"/>
  public string FontName { get; set; }

  /// <summary>
  /// Returns or sets the font size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontsize?view=word-pia"/>
  public float FontSize { get; set; }

  /// <summary>
  /// Returns or sets whether kerned pairs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.kernedpairs?view=word-pia"/>
  public Core.MsoTriState KernedPairs { get; set; }

  /// <summary>
  /// Returns or sets whether normalized height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.normalizedheight?view=word-pia"/>
  public Core.MsoTriState NormalizedHeight { get; set; }

  /// <summary>
  /// Returns or sets the preset shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presetshape?view=word-pia"/>
  public Core.MsoPresetTextEffectShape PresetShape { get; set; }

  /// <summary>
  /// Returns or sets the preset text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presettexteffect?view=word-pia"/>
  public Core.MsoPresetTextEffect PresetTextEffect { get; set; }

  /// <summary>
  /// Returns or sets whether rotated chars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.rotatedchars?view=word-pia"/>
  public Core.MsoTriState RotatedChars { get; set; }

  /// <summary>
  /// Returns or sets the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets the tracking.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.tracking?view=word-pia"/>
  public float Tracking { get; set; }
}
