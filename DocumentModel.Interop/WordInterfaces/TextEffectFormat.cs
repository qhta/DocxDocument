namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to WordArt objects.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat?view=word-pia"/>
public partial interface TextEffectFormat : InteropObject
{
  /// <summary>
  /// The alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.alignment?view=word-pia"/>
  public Core.MsoTextEffectAlignment Alignment { get; set; }

  /// <summary>
  /// The font bold.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontbold?view=word-pia"/>
  public Core.MsoTriState FontBold { get; set; }

  /// <summary>
  /// The font italic.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontitalic?view=word-pia"/>
  public Core.MsoTriState FontItalic { get; set; }

  /// <summary>
  /// The font name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontname?view=word-pia"/>
  public string FontName { get; set; }

  /// <summary>
  /// The font size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontsize?view=word-pia"/>
  public float FontSize { get; set; }

  /// <summary>
  /// The kerned pairs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.kernedpairs?view=word-pia"/>
  public Core.MsoTriState KernedPairs { get; set; }

  /// <summary>
  /// The normalized height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.normalizedheight?view=word-pia"/>
  public Core.MsoTriState NormalizedHeight { get; set; }

  /// <summary>
  /// The preset shape.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presetshape?view=word-pia"/>
  public Core.MsoPresetTextEffectShape PresetShape { get; set; }

  /// <summary>
  /// The preset text effect.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presettexteffect?view=word-pia"/>
  public Core.MsoPresetTextEffect PresetTextEffect { get; set; }

  /// <summary>
  /// The rotated chars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.rotatedchars?view=word-pia"/>
  public Core.MsoTriState RotatedChars { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The tracking.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.tracking?view=word-pia"/>
  public float Tracking { get; set; }
}
