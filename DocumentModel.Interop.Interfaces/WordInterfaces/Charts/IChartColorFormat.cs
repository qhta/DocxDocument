namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents the color of a one-color object or the foreground or background color of an object with a gradient or patterned fill.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat?view=word-pia"/>
public interface IChartColorFormat : IInteropObject
{
  /// <summary>
  /// Gets or sets the color in the current color scheme.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.schemecolor?view=word-pia"/>
  public int SchemeColor { get; set; }
  /// <summary>
  /// Gets the red-green-blue (RGB) value of the color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.rgb?view=word-pia"/>
  public int RGB { get; }
  /// <summary>
  /// Gets the default color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat._default?view=word-pia"/>
  public int _Default { get; }
  /// <summary>
  /// Gets the type of color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcolorformat.type?view=word-pia"/>
  public int Type { get; }	
}
