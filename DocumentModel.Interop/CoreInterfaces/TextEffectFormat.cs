
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextEffectFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat?view=office-pia"/>
public partial interface ITextEffectFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.alignment?view=office-pia"/>
  public TextEffectAlignment Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `FontBold` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontbold?view=office-pia"/>
  public TriState FontBold { get; set; }
  /// <summary>
  /// Gets or sets the `FontItalic` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontitalic?view=office-pia"/>
  public TriState FontItalic { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontname?view=office-pia"/>
  public string FontName { get; set; }
  /// <summary>
  /// Gets or sets the `FontSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontsize?view=office-pia"/>
  public float FontSize { get; set; }
  /// <summary>
  /// Gets or sets the `KernedPairs` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.kernedpairs?view=office-pia"/>
  public TriState KernedPairs { get; set; }
  /// <summary>
  /// Gets or sets the `NormalizedHeight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.normalizedheight?view=office-pia"/>
  public TriState NormalizedHeight { get; set; }
  /// <summary>
  /// Gets or sets the `PresetShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.presetshape?view=office-pia"/>
  public PresetTextEffectShape PresetShape { get; set; }
  /// <summary>
  /// Gets or sets the `PresetTextEffect` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.presettexteffect?view=office-pia"/>
  public PresetTextEffect PresetTextEffect { get; set; }
  /// <summary>
  /// Gets or sets the `RotatedChars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.rotatedchars?view=office-pia"/>
  public TriState RotatedChars { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Tracking` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.tracking?view=office-pia"/>
  public float Tracking { get; set; }
}

