namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat?view=word-pia"/>
public partial class ColorFormat : InteropObject
{
  /// <summary>
  /// Gets or sets the red-green-blue (RGB) value of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.rgb?view=word-pia"/>
  public int RGB { get; set; }

  /// <summary>
  /// Gets or sets the color in the current color scheme.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.schemecolor?view=word-pia"/>
  public int SchemeColor { get; set; }

  /// <summary>
  /// Gets the type of color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.type?view=word-pia"/>
  public Core.ColorType Type { get; set; }

  /// <summary>
  /// Gets or sets the name of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Gets or sets the tint or shade value for the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.tintandshade?view=word-pia"/>
  public float TintAndShade { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether overprint is enabled for the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.overprint?view=word-pia"/>
  public Core.TriState OverPrint { get; set; }

  /// <summary>
  /// Gets or sets the cyan component of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.cyan?view=word-pia"/>
  public int Cyan { get; set; }

  /// <summary>
  /// Gets or sets the magenta component of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.magenta?view=word-pia"/>
  public int Magenta { get; set; }

  /// <summary>
  /// Gets or sets the yellow component of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.yellow?view=word-pia"/>
  public int Yellow { get; set; }

  /// <summary>
  /// Gets or sets the black component of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.black?view=word-pia"/>
  public int Black { get; set; }

  /// <summary>
  /// Gets or sets the theme color applied to the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.objectthemecolor?view=word-pia"/>
  public ThemeColorIndex ObjectThemeColor { get; set; }

  /// <summary>
  /// Gets or sets the brightness of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.brightness?view=word-pia"/>
  public float Brightness { get; set; }
}
