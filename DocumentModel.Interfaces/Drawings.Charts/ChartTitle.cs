
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart title.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle?view=office-pia"/>
public partial interface IChartTitle: IModelObject
{
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.caption?view=office-pia"/>
  public string Caption { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.characters?view=office-pia"/>
  public ICharacters Characters { get; }
  /// <summary>
  /// Gets the `TextFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.font?view=office-pia"/>
  public IChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `HorizontalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.horizontalalignment?view=office-pia"/>
  public object HorizontalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.left?view=office-pia"/>
  public double Left { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.orientation?view=office-pia"/>
  public object Orientation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.shadow?view=office-pia"/>
  public bool Shadow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.text?view=office-pia"/>
  public string Text { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.top?view=office-pia"/>
  public double Top { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `VerticalAlignment` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.verticalalignment?view=office-pia"/>
  public object VerticalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ReadingOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.readingorder?view=office-pia"/>
  public int ReadingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `AutoScaleFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.autoscalefont?view=office-pia"/>
  public object AutoScaleFont { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `IncludeInLayout` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.includeinlayout?view=office-pia"/>
  public bool IncludeInLayout { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.position?view=office-pia"/>
  public XlChartElementPosition Position { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.format?view=office-pia"/>
  public IChartFormat Format { get; }
  /// <summary>
  /// Gets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.height?view=office-pia"/>
  public double Height { get; }
  /// <summary>
  /// Gets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.width?view=office-pia"/>
  public double Width { get; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.formula?view=office-pia"/>
  public string Formula { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.formular1c1?view=office-pia"/>
  public string FormulaR1C1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.formulalocal?view=office-pia"/>
  public string FormulaLocal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharttitle.formular1c1local?view=office-pia"/>
  public string FormulaR1C1Local { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

