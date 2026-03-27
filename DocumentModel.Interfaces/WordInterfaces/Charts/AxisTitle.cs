using DocumentModel.Drawings.Charts;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the title of an axis in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle?view=word-pia"/>
public partial interface AxisTitle : InteropObject
{
  /// <summary>
  /// Gets or sets the caption text for the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Gets the font formatting for the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets the horizontal alignment of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the chart area to the left edge of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Gets or sets the text orientation of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis title has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the text of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the chart area to the top edge of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets the interior formatting of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets the border formatting of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the name of the axis title object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis title occupies chart layout space when layout is calculated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.includeinlayout?view=word-pia"/>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// Gets or sets the position of the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.position?view=word-pia"/>
  public ChartElementPosition Position { get; set; }

  /// <summary>
  /// Gets the chart formatting for the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Gets the height of the axis title, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Gets the width of the axis title, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Gets or sets the formula for the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Gets or sets the formula for the axis title in R1C1-style notation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Gets or sets the formula for the axis title in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Gets or sets the formula for the axis title in R1C1-style notation in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axistitle.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }
}
