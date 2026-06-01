namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a unit label on an axis in the specified chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel?view=word-pia"/>
public partial class DisplayUnitLabel : InteropObject
{
  /// <summary>
  /// Gets or sets the caption text for the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Gets the font formatting for the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// Gets or sets the horizontal alignment of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.horizontalalignment?view=word-pia"/>
  public object HorizontalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the left edge of the chart area to the left edge of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.left?view=word-pia"/>
  public double Left { get; set; }

  /// <summary>
  /// Gets or sets the text orientation of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.orientation?view=word-pia"/>
  public object Orientation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the display-unit label has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the text of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, from the top edge of the chart area to the top edge of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.top?view=word-pia"/>
  public double Top { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.verticalalignment?view=word-pia"/>
  public object VerticalAlignment { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.readingorder?view=word-pia"/>
  public int ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets whether the font size is scaled automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.autoscalefont?view=word-pia"/>
  public object AutoScaleFont { get; set; }

  /// <summary>
  /// Gets the interior formatting of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Gets the fill formatting of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Gets the border formatting of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Gets the name of the display-unit label object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the display-unit label occupies chart layout space when layout is calculated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.includeinlayout?view=word-pia"/>
  public bool IncludeInLayout { get; set; }

  /// <summary>
  /// Gets or sets the position of the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.position?view=word-pia"/>
  public ChartElementPosition Position { get; set; }

  /// <summary>
  /// Gets the chart formatting for the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Gets the height of the display-unit label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Gets the width of the display-unit label, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Gets or sets the formula for the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Gets or sets the formula for the display-unit label in R1C1-style notation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Gets or sets the formula for the display-unit label in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Gets or sets the formula for the display-unit label in R1C1-style notation in the language of the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.displayunitlabel.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }
}
