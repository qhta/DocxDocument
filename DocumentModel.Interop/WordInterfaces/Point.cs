namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single point in a series in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point?view=word-pia"/>
public partial interface Point : InteropObject
{
  /// <summary>
  /// Returns the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.datalabel?view=word-pia"/>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// Returns or sets the explosion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.explosion?view=word-pia"/>
  public int Explosion { get; set; }

  /// <summary>
  /// Returns or sets whether data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.hasdatalabel?view=word-pia"/>
  public bool HasDataLabel { get; set; }

  /// <summary>
  /// Returns the interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns or sets whether invert if negative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// Returns or sets the marker background color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker background color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerbackgroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerforegroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// Returns or sets the marker style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerstyle?view=word-pia"/>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// Returns or sets the picture type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.picturetype?view=word-pia"/>
  public XlChartPictureType PictureType { get; set; }

  /// <summary>
  /// Returns or sets the picture unit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to sides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttosides?view=word-pia"/>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to front.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttofront?view=word-pia"/>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttoend?view=word-pia"/>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// Returns or sets whether shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Returns or sets whether secondary plot.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.secondaryplot?view=word-pia"/>
  public bool SecondaryPlot { get; set; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets whether 3 d effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.has3deffect?view=word-pia"/>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the picture unit2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// Returns the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Returns the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Returns the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// Returns the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.name?view=word-pia"/>
  public string Name { get; }
}
