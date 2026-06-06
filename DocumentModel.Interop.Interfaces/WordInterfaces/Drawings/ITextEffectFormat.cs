namespace DocumentModel.Interop.Word;	
/// <summary>
/// Contains properties and methods that apply to WordArt objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat?view=word-pia"/>
public interface ITextEffectFormat : IInteropObject
{
  /// <summary>
  /// Returns or sets a constant that represents the alignment for the specified text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.alignment?view=word-pia"/>
  public Core.TextEffectAlignment Alignment { get; set; }	
  /// <summary>
  /// Returns or sets a constant that represents how bold font is handled for the specified text effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontbold?view=word-pia"/>
  public Core.TriState FontBold { get; set; }	
  /// <summary>
  /// Italicizes WordArt text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontitalic?view=word-pia"/>
  public Core.TriState FontItalic { get; set; }	
  /// <summary>
  /// Returns or sets the name of the font for the dropped capital letter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontname?view=word-pia"/>
  public string FontName { get; set; }	
  /// <summary>
  /// Returns or sets the font size for the specified WordArt, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.fontsize?view=word-pia"/>
  public float FontSize { get; set; }	
  /// <summary>
  /// Indicates that character pairs in a WordArt object have been kerned.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.kernedpairs?view=word-pia"/>
  public Core.TriState KernedPairs { get; set; }	
  /// <summary>
  /// MsoTrue if all characters (both uppercase and lowercase) in the specified WordArt are the same height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.normalizedheight?view=word-pia"/>
  public Core.TriState NormalizedHeight { get; set; }	
  /// <summary>
  /// Returns or sets the shape of the specified WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presetshape?view=word-pia"/>
  public Core.PresetTextEffectShape PresetShape { get; set; }	
  /// <summary>
  /// Returns or sets the style of the specified WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.presettexteffect?view=word-pia"/>
  public Core.PresetTextEffect PresetTextEffect { get; set; }	
  /// <summary>
  /// MsoTrue if characters in the specified WordArt are rotated 90 degrees relative to the WordArt's bounding
  /// shape. MsoFalse if characters in the specified WordArt retain their original orientation relative to the
  /// bounding shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.rotatedchars?view=word-pia"/>
  public Core.TriState RotatedChars { get; set; }	
  /// <summary>
  /// Returns or sets the text in the specified WordArt.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.text?view=word-pia"/>
  public string Text { get; set; }	
  /// <summary>
  /// Returns or sets the ratio of the horizontal space allotted to each character in the specified WordArt in
  /// relation to the width of the character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.tracking?view=word-pia"/>
  public float Tracking { get; set; }	

  #region methods	
/// <summary>
  /// Switches the text flow in the specified WordArt from horizontal to vertical, or vice versa.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.texteffectformat.toggleverticaltext?view=word-pia"/>
  public void ToggleVerticalText();	
  #endregion methods
}
