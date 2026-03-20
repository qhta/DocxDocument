
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextEffectFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TextEffectFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Alignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.alignment?view=office-pia
  /// </remarks>
  public MsoTextEffectAlignment Alignment { get; set; }
  /// <summary>
  /// Gets or sets the `FontBold` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontbold?view=office-pia
  /// </remarks>
  public MsoTriState FontBold { get; set; }
  /// <summary>
  /// Gets or sets the `FontItalic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontitalic?view=office-pia
  /// </remarks>
  public MsoTriState FontItalic { get; set; }
  /// <summary>
  /// Gets or sets the `FontName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontname?view=office-pia
  /// </remarks>
  public string FontName { get; set; }
  /// <summary>
  /// Gets or sets the `FontSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.fontsize?view=office-pia
  /// </remarks>
  public float FontSize { get; set; }
  /// <summary>
  /// Gets or sets the `KernedPairs` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.kernedpairs?view=office-pia
  /// </remarks>
  public MsoTriState KernedPairs { get; set; }
  /// <summary>
  /// Gets or sets the `NormalizedHeight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.normalizedheight?view=office-pia
  /// </remarks>
  public MsoTriState NormalizedHeight { get; set; }
  /// <summary>
  /// Gets or sets the `PresetShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.presetshape?view=office-pia
  /// </remarks>
  public MsoPresetTextEffectShape PresetShape { get; set; }
  /// <summary>
  /// Gets or sets the `PresetTextEffect` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.presettexteffect?view=office-pia
  /// </remarks>
  public MsoPresetTextEffect PresetTextEffect { get; set; }
  /// <summary>
  /// Gets or sets the `RotatedChars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.rotatedchars?view=office-pia
  /// </remarks>
  public MsoTriState RotatedChars { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Tracking` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.tracking?view=office-pia
  /// </remarks>
  public float Tracking { get; set; }
}
