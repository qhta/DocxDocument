namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a trendline in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline?view=word-pia"/>
public partial interface Trendline : InteropObject
{
  /// <summary>
  /// The backward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward?view=word-pia"/>
  public double Backward { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The data label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.datalabel?view=word-pia"/>
  public DataLabel DataLabel { get; }

  /// <summary>
  /// The display equation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayequation?view=word-pia"/>
  public bool DisplayEquation { get; set; }

  /// <summary>
  /// The display rsquared.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.displayrsquared?view=word-pia"/>
  public bool DisplayRSquared { get; set; }

  /// <summary>
  /// The forward.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward?view=word-pia"/>
  public double Forward { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The intercept.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.intercept?view=word-pia"/>
  public double Intercept { get; set; }

  /// <summary>
  /// The intercept is auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.interceptisauto?view=word-pia"/>
  public bool InterceptIsAuto { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The name is auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.nameisauto?view=word-pia"/>
  public bool NameIsAuto { get; set; }

  /// <summary>
  /// The order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.order?view=word-pia"/>
  public int Order { get; set; }

  /// <summary>
  /// The period.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.period?view=word-pia"/>
  public int Period { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.type?view=word-pia"/>
  public XlTrendlineType Type { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// The backward2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.backward2?view=word-pia"/>
  public double Backward2 { get; set; }

  /// <summary>
  /// The forward2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendline.forward2?view=word-pia"/>
  public double Forward2 { get; set; }
}
