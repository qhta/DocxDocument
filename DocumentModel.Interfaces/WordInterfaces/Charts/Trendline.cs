using DocumentModel.Interop.Core;

namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline?view=word-pia"/>
public partial interface Trendline : InteropObject
{
  /// <summary>
  /// Returns or sets the number of periods (or units on a scatter chart) that the trendline extends backward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward?view=word-pia"/>
  public double Backward { get; set; }

  /// <summary>
  /// Returns a ChartBorder object that represents the border of the object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns a DataLabel object that represents the data label associated with the trendline. Read- only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.datalabel?view=word-pia"/>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// True if the equation for the trendline is displayed on the chart (in the same data label as the R- squared
  /// value). Setting this property to True automatically turns on data labels. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayequation?view=word-pia"/>
  public bool DisplayEquation { get; set; }

  /// <summary>
  /// True if the R-squared value of the trendline is displayed on the chart (in the same data label as the
  /// equation). Setting this property to True automatically turns on data labels. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayrsquared?view=word-pia"/>
  public bool DisplayRSquared { get; set; }

  /// <summary>
  /// Returns or sets the number of periods (or units on a scatter chart) that the trendline extends forward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward?view=word-pia"/>
  public double Forward { get; set; }

  /// <summary>
  /// Returns the index number of the object within the collection of similar objects.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the point where the trendline crosses the value axis. Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.intercept?view=word-pia"/>
  public double Intercept { get; set; }

  /// <summary>
  /// True if the point where the trendline crosses the value axis is automatically determined by the regression.
  /// Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.interceptisauto?view=word-pia"/>
  public bool InterceptIsAuto { get; set; }

  /// <summary>
  /// Returns or sets a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// True if Microsoft Word automatically determines the name of the trendline. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.nameisauto?view=word-pia"/>
  public bool NameIsAuto { get; set; }

  /// <summary>
  /// Returns or sets a Integer value that represents the trendline order (an integer greater than 1) when the
  /// trendline’s Type is xlPolynomial.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.order?view=word-pia"/>
  public int Order { get; set; }

  /// <summary>
  /// Returns or sets the period for the moving-average trendline. Can be a value from 2 through 255. Read/write
  /// Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.period?view=word-pia"/>
  public int Period { get; set; }

  /// <summary>
  /// Returns or sets a TrendlineType value that represents the trendline type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.type?view=word-pia"/>
  public TrendlineType Type { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the number of periods (or units on a scatter chart) that the trendline extends backward.
  /// Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward2?view=word-pia"/>
  public double Backward2 { get; set; }

  /// <summary>
  /// Returns or sets the number of periods (or units on a scatter chart) that the trendline extends forward.
  /// Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward2?view=word-pia"/>
  public double Forward2 { get; set; }
}
