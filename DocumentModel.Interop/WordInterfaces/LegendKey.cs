namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a legend key in a chart legend.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey?view=word-pia"/>
public partial interface LegendKey : InteropObject
{
  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The invert if negative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// The marker background color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// The marker background color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerbackgroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// The marker foreground color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// The marker foreground color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerforegroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// The marker size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// The marker style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerstyle?view=word-pia"/>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// The picture type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.picturetype?view=word-pia"/>
  public int PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// The smooth.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.smooth?view=word-pia"/>
  public bool Smooth { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// The picture unit2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }
}
