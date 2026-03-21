namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the chart title.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle?view=word-pia"/>
public partial interface ChartTitle : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The horizontal alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// The auto scale font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The include in layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.includeinlayout?view=word-pia"/>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.position?view=word-pia"/>
  public XlChartElementPosition Position { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// The formula.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// The formula r1 c1.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// The formula local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// The formula r1 c1 local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }
}
