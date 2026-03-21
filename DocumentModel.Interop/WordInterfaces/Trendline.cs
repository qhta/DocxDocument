namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline?view=word-pia"/>
public partial interface Trendline : InteropObject
{
  /// <summary>
  /// Returns or sets the backward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward?view=word-pia"/>
  public double Backward { get; set; }

  /// <summary>
  /// Returns the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.datalabel?view=word-pia"/>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// Returns or sets whether display equation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayequation?view=word-pia"/>
  public bool DisplayEquation { get; set; }

  /// <summary>
  /// Returns or sets whether display r squared.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayrsquared?view=word-pia"/>
  public bool DisplayRSquared { get; set; }

  /// <summary>
  /// Returns or sets the forward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward?view=word-pia"/>
  public double Forward { get; set; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the intercept.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.intercept?view=word-pia"/>
  public double Intercept { get; set; }

  /// <summary>
  /// Returns or sets whether intercept is auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.interceptisauto?view=word-pia"/>
  public bool InterceptIsAuto { get; set; }

  /// <summary>
  /// Returns or sets the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns or sets whether name is auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.nameisauto?view=word-pia"/>
  public bool NameIsAuto { get; set; }

  /// <summary>
  /// Returns or sets the order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.order?view=word-pia"/>
  public int Order { get; set; }

  /// <summary>
  /// Returns or sets the period.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.period?view=word-pia"/>
  public int Period { get; set; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.type?view=word-pia"/>
  public XlTrendlineType Type { get; set; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the backward2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward2?view=word-pia"/>
  public double Backward2 { get; set; }

  /// <summary>
  /// Returns or sets the forward2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward2?view=word-pia"/>
  public double Forward2 { get; set; }
}
