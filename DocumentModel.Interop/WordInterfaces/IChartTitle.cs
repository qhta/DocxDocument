namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the chart title.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle?view=word-pia"/>
public interface IChartTitle : IInteropObject
{
  /// <summary>
  /// Gets or sets the caption text for the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Gets the font formatting for the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets the horizontal alignment of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the chart area to the left edge of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Gets or sets the text orientation of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart title has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the text of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the chart area to the top edge of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets the interior formatting of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets the border formatting of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the name of the chart title object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart title occupies chart layout space when layout is calculated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.includeinlayout?view=word-pia"/>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// Gets or sets the position of the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.position?view=word-pia"/>
  public ChartElementPosition Position { get; set; }

  /// <summary>
  /// Gets the chart formatting for the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Gets the height of the chart title, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Gets the width of the chart title, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Gets or sets the formula for the chart title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Gets or sets the formula for the chart title in R1C1-style notation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Gets or sets the formula for the chart title in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Gets or sets the formula for the chart title in R1C1-style notation in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }


  #region methods

/// <summary>
  /// Returns a ChartCharacters object that represents a range of characters in the chart title text.
  /// </summary>
  /// <param name="Start">The starting character position.</param>
  /// <param name="Length">The number of characters to return.</param>
  /// <returns>The requested <see cref="ChartCharacters"/> range.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.get_characters?view=word-pia"/>
  public ChartCharacters Characters(object Start, object Length);

  /// <summary>
  /// Deletes the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.charttitle.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
