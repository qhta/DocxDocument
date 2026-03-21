namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat?view=word-pia"/>
public partial interface ColorFormat : InteropObject
{
  /// <summary>
  /// The rgb.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.rgb?view=word-pia"/>
  public int RGB { get; set; }

  /// <summary>
  /// The scheme color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.schemecolor?view=word-pia"/>
  public int SchemeColor { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.type?view=word-pia"/>
  public Core.MsoColorType Type { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The tint and shade.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.tintandshade?view=word-pia"/>
  public float TintAndShade { get; set; }

  /// <summary>
  /// The over print.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.overprint?view=word-pia"/>
  public Core.MsoTriState OverPrint { get; set; }

  /// <summary>
  /// The cyan.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.cyan?view=word-pia"/>
  public int Cyan { get; set; }

  /// <summary>
  /// The magenta.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.magenta?view=word-pia"/>
  public int Magenta { get; set; }

  /// <summary>
  /// The yellow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.yellow?view=word-pia"/>
  public int Yellow { get; set; }

  /// <summary>
  /// The black.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.black?view=word-pia"/>
  public int Black { get; set; }

  /// <summary>
  /// The object theme color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.objectthemecolor?view=word-pia"/>
  public WdThemeColorIndex ObjectThemeColor { get; set; }

  /// <summary>
  /// The brightness.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.colorformat.brightness?view=word-pia"/>
  public float Brightness { get; set; }
}
