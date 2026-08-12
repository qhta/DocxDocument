namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents an axis in a chart drawing that defines the scale and appearance of data dimensions.
/// </summary>
/// <remarks>
///   This class defines a chart axis that provides the framework
///   for displaying and measuring data values in chart visualizations. Axes can be category axes (for discrete
///   data like labels or dates) or value axes (for continuous numeric data), each with their own scaling properties.
///   The axis includes comprehensive formatting options including title, units, gridlines (major and minor),
///   tick marks, tick labels, number formatting, visual styling, and text properties. Axes can be hidden while
///   still providing the underlying data structure, and support extensibility through custom extensions.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Axis))]
[DataContract]
[XmlRoot("Axis", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Axis : ModelElement<DXO16DCD.Axis>
{
  /// <summary>
  /// Specifies the unique identifier of the element.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Axis.Id))]
  public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private UInt32? _Id;
  /// <summary>
  /// Specifies the hidden.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Axis.Hidden))]
  public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

  private bool? _Hidden;
  /// <summary>
  /// Specifies the category axis scaling.
  /// </summary>
  public CategoryAxisScaling? CategoryAxisScaling { get => _CategoryAxisScaling; set => UpdateField(ref _CategoryAxisScaling, value, nameof(CategoryAxisScaling)); }

  private CategoryAxisScaling? _CategoryAxisScaling;
  /// <summary>
  /// Specifies the value axis scaling.
  /// </summary>
  public ValueAxisScaling? ValueAxisScaling { get => _ValueAxisScaling; set => UpdateField(ref _ValueAxisScaling, value, nameof(ValueAxisScaling)); }

  private ValueAxisScaling? _ValueAxisScaling;
  /// <summary>
  /// Specifies the axis title.
  /// </summary>
  public AxisTitle? AxisTitle { get => _AxisTitle; set => UpdateField(ref _AxisTitle, value, nameof(AxisTitle)); }

  private AxisTitle? _AxisTitle;
  /// <summary>
  /// Specifies the axis units.
  /// </summary>
  public AxisUnits? AxisUnits { get => _AxisUnits; set => UpdateField(ref _AxisUnits, value, nameof(AxisUnits)); }

  private AxisUnits? _AxisUnits;
  /// <summary>
  /// Specifies the major gridlines gridlines.
  /// </summary>
  public MajorGridlinesGridlines? MajorGridlinesGridlines { get => _MajorGridlinesGridlines; set => UpdateField(ref _MajorGridlinesGridlines, value, nameof(MajorGridlinesGridlines)); }

  private MajorGridlinesGridlines? _MajorGridlinesGridlines;
  /// <summary>
  /// Specifies the minor gridlines gridlines.
  /// </summary>
  public MinorGridlinesGridlines? MinorGridlinesGridlines { get => _MinorGridlinesGridlines; set => UpdateField(ref _MinorGridlinesGridlines, value, nameof(MinorGridlinesGridlines)); }

  private MinorGridlinesGridlines? _MinorGridlinesGridlines;
  /// <summary>
  /// Specifies the major tick marks tick marks.
  /// </summary>
  public MajorTickMarksTickMarks? MajorTickMarksTickMarks { get => _MajorTickMarksTickMarks; set => UpdateField(ref _MajorTickMarksTickMarks, value, nameof(MajorTickMarksTickMarks)); }

  private MajorTickMarksTickMarks? _MajorTickMarksTickMarks;
  /// <summary>
  /// Specifies the minor tick marks tick marks.
  /// </summary>
  public MinorTickMarksTickMarks? MinorTickMarksTickMarks { get => _MinorTickMarksTickMarks; set => UpdateField(ref _MinorTickMarksTickMarks, value, nameof(MinorTickMarksTickMarks)); }

  private MinorTickMarksTickMarks? _MinorTickMarksTickMarks;
  /// <summary>
  /// Specifies the tick labels.
  /// </summary>
  public TickLabels? TickLabels { get => _TickLabels; set => UpdateField(ref _TickLabels, value, nameof(TickLabels)); }

  private TickLabels? _TickLabels;
  /// <summary>
  /// Specifies the number format.
  /// </summary>
  public NumberFormat? NumberFormat { get => _NumberFormat; set => UpdateField(ref _NumberFormat, value, nameof(NumberFormat)); }

  private NumberFormat? _NumberFormat;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get => _TxPrTextBody; set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody)); }

  private TxPrTextBody? _TxPrTextBody;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private IExtensionList? _ExtensionList;
}