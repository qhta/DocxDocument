namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single point in a series in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point?view=word-pia"/>
public interface IPoint : IInteropObject
{
  /// <summary>
  /// Returns a Border object that represents the border of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns a DataLabel object that represents the data label associated with the point. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.datalabel?view=word-pia"/>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// Returns or sets the explosion value for a pie-chart or doughnut-chart slice. Returns 0 (zero) if there's no
  /// explosion (the tip of the slice is in the center of the pie). Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.explosion?view=word-pia"/>
  public int Explosion { get; set; }

  /// <summary>
  /// True if the point has a data label. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.hasdatalabel?view=word-pia"/>
  public bool HasDataLabel { get; set; }

  /// <summary>
  /// Returns an Interior object that represents the interior of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// True if Microsoft Word inverts the pattern in the object when it corresponds to a negative number. Read/write
  /// Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// Sets the marker background color as an RGB value or returns the corresponding color index value. Applies only
  /// to line, scatter, and radar charts. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker background color as an index into the current color palette, or as one of the
  /// following ColorIndex constants: xlColorIndexAutomatic or xlColorIndexNone. Applies only to line, scatter,
  /// and radar charts. Read/write ColorIndex.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerbackgroundcolorindex?view=word-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// Sets the marker foreground color as an RGB value or returns the corresponding color index value. Applies only
  /// to line, scatter, and radar charts. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color as an index into the current color palette, or as one of the
  /// following ColorIndex constants: xlColorIndexAutomatic or xlColorIndexNone. Applies only to line, scatter,
  /// and radar charts. Read/write ColorIndex.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerforegroundcolorindex?view=word-pia"/>
  public ColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the data-marker size, in points. Can be a value from 2 through 72. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// Returns or sets the marker style for a point or series in a line chart, scatter chart, or radar chart.
  /// Read/write MarkerStyle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.markerstyle?view=word-pia"/>
  public MarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// Returns or sets a ChartPictureType value that represents the way pictures are displayed on a column or bar
  /// picture chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.picturetype?view=word-pia"/>
  public ChartPictureType PictureType { get; set; }

  /// <summary>
  /// Returns or sets the unit for each picture on the chart if the PictureType property is set to xlStackScale (if
  /// not, this property is ignored).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// True if a picture is applied to the sides of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttosides?view=word-pia"/>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// True if a picture is applied to the front of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttofront?view=word-pia"/>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// True if a picture is applied to the end of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.applypicttoend?view=word-pia"/>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// Returns or sets a Boolean value that determines if the object has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// True if the point is in the secondary section of either a pie of pie chart or a bar of pie chart. Applies only
  /// to points on pie of pie charts or bar of pie charts. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.secondaryplot?view=word-pia"/>
  public bool SecondaryPlot { get; set; }

  /// <summary>
  /// Returns a FillFormat object for a specified shape or a ChartFillFormat object for a specified chart that
  /// contains fill formatting properties for the shape or chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// True if a point has a three-dimensional appearance. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.has3deffect?view=word-pia"/>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the unit for each picture on the chart if the PictureType property is set to xlStackScale (if
  /// not, this property is ignored). Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// Gets the height, in points, of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Gets the width, in points, of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Gets a value that represents the distance, in points, from the top edge of the object to the top edge of the
  /// chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// Gets a value that represents the distance, in points, from the left edge of the object to the left edge of the
  /// chart area.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// Gets the object name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.name?view=word-pia"/>
  public string Name { get; }


  #region methods

/// <summary>
  /// Clears the formatting of the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.point.clearformats?view=word-pia"/>
  public void ClearFormats();

  #endregion methods
}
