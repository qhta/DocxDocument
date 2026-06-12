
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart axis title.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle?view=office-pia"/>
public partial interface IAxisTitle: IChartTitle
{
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.caption?view=office-pia"/>
  public new string Caption { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.characters?view=office-pia"/>
  public new ICharacters Characters { get; }
  /// <summary>
  /// Gets the `TextFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.font?view=office-pia"/>
  public new IChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.horizontalalignment?view=office-pia"/>
  public new object HorizontalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.left?view=office-pia"/>
  public new double Left { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.orientation?view=office-pia"/>
  public new object Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.shadow?view=office-pia"/>
  public new bool Shadow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.text?view=office-pia"/>
  public new string Text { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.top?view=office-pia"/>
  public new double Top { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.verticalalignment?view=office-pia"/>
  public new object VerticalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.readingorder?view=office-pia"/>
  public new int ReadingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.autoscalefont?view=office-pia"/>
  public new object AutoScaleFont { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.interior?view=office-pia"/>
  public new Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.fill?view=office-pia"/>
  public new IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.border?view=office-pia"/>
  public new IBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.name?view=office-pia"/>
  public new string Name { get; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.includeinlayout?view=office-pia"/>
  public new bool IncludeInLayout { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.position?view=office-pia"/>
  public new XlChartElementPosition Position { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.format?view=office-pia"/>
  public new IChartFormat Format { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.height?view=office-pia"/>
  public new double Height { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.width?view=office-pia"/>
  public new double Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.formula?view=office-pia"/>
  public new string Formula { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.formular1c1?view=office-pia"/>
  public new string FormulaR1C1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.formulalocal?view=office-pia"/>
  public new string FormulaLocal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.formular1c1local?view=office-pia"/>
  public new string FormulaR1C1Local { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

