namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a legend key in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey?view=word-pia"/>
public partial interface LegendKey : InteropObject
{
  /// <summary>
  /// Returns a border object that represents the border of the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns an interior object that represents the interior of the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns fill formatting properties for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets whether the data point fill is inverted when the value is negative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// Returns or sets the marker background color for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker background color index for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerbackgroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color index for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerforegroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker size for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// Returns or sets the marker style for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.markerstyle?view=word-pia"/>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// Returns or sets the picture display type for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.picturetype?view=word-pia"/>
  public int PictureType { get; set; }

  /// <summary>
  /// Returns or sets the unit used for picture display in the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// Returns or sets whether line smoothing is turned on for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.smooth?view=word-pia"/>
  public bool Smooth { get; set; }

  /// <summary>
  /// Returns the distance, in points, from the left edge of the chart area to the left edge of the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// Returns the distance, in points, from the top edge of the chart area to the top edge of the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// Returns the width of the legend key, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Returns the height of the legend key, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Returns or sets whether the legend key has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Returns the chart format properties for the legend key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the picture unit for modern charting behavior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendkey.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }
}
