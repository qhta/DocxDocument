namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains font attributes (font name, font size, color, and so on) for an object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.font?view=word-pia"/>
public partial interface ITextFormat
{

  /// <summary>
  /// Gets or sets the shading formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shading?view=word-pia"/>
  public DMD.IShading? Shading { get; set; }

  /// <summary>
  /// Gets or sets the glow formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.glow?view=word-pia"/>
  public DMD.IGlowFormat? Glow { get; set; }

  /// <summary>
  /// Gets or sets the reflection formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.reflection?view=word-pia"/>
  public DMD.IReflectionFormat? Reflection { get; set; }

  /// <summary>
  /// Gets or sets the shadow formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textshadow?view=word-pia"/>
  public DMD.IShadowFormat? TextShadow { get; set; }

  /// <summary>
  /// Gets or sets the fill formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.fill?view=word-pia"/>
  public DMD.IFillFormat? Fill { get; set; }

  /// <summary>
  /// Gets or sets the line formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.line?view=word-pia"/>
  public DMD.ILineFormat? Line { get; set; }

  /// <summary>
  /// Gets or sets the 3D formatting for the font.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.threed?view=word-pia"/>
  public DMD.IThreeDFormat? ThreeD { get; set; }

  /// <summary>
  /// Gets or sets the full text color formatting.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textcolor?view=word-pia"/>
  public DMD.IColorFormat? TextColor { get; set; }
}
