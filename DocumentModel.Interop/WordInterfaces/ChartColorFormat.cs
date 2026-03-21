namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat?view=word-pia"/>
public interface ChartColorFormat : InteropObject
{
  /// <summary>
  /// The scheme color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.schemecolor?view=word-pia"/>
  public int SchemeColor { get; set; }
  /// <summary>
  /// The rgb.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.rgb?view=word-pia"/>
  public int RGB { get; }
  /// <summary>
  /// The _default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat._default?view=word-pia"/>
  public int _Default { get; }
  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.type?view=word-pia"/>
  public int Type { get; }

}
