namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Chart Space.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartSpace))]
[XmlRoot("ChartSpace", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ChartSpace : ModelElement<DXDC.ChartSpace>
{
 /// <summary>
 ///   Date1904.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartSpace.Date1904))]
 public bool? Date1904 { get => _Date1904; set => UpdateField(ref _Date1904, value, nameof(Date1904)); }

 private bool? _Date1904;
 /// <summary>
 ///   EditingLanguage.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartSpace.EditingLanguage))]
 public string? EditingLanguage { get => _EditingLanguage; set => UpdateField(ref _EditingLanguage, value, nameof(EditingLanguage)); }

 private string? _EditingLanguage;
 /// <summary>
 ///   RoundedCorners.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartSpace.RoundedCorners))]
 public bool? RoundedCorners { get => _RoundedCorners; set => UpdateField(ref _RoundedCorners, value, nameof(RoundedCorners)); }

 private bool? _RoundedCorners;
 /// <summary>
 ///   Style.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Style))]
 public Byte? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private Byte? _Style;
 /// <summary>
 ///   Color Map Override.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ColorMapOverride))]
 public ColorMapOverride? ColorMapOverride { get => _ColorMapOverride; set => UpdateField(ref _ColorMapOverride, value, nameof(ColorMapOverride)); }

 private ColorMapOverride? _ColorMapOverride;
 /// <summary>
 ///   Pivot Source.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PivotSource))]
 public PivotSource? PivotSource { get => _PivotSource; set => UpdateField(ref _PivotSource, value, nameof(PivotSource)); }

 private PivotSource? _PivotSource;
 /// <summary>
 ///   Protection.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Protection))]
 public Protection? Protection { get => _Protection; set => UpdateField(ref _Protection, value, nameof(Protection)); }

 private Protection? _Protection;
 /// <summary>
 ///   Chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Chart))]
 public Chart? Chart { get => _Chart; set => UpdateField(ref _Chart, value, nameof(Chart)); }

 private Chart? _Chart;
 /// <summary>
 ///   Shape Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 ///   Text Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TextProperties))]
 public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }

 private TextProperties? _TextProperties;
 /// <summary>
 ///   External Data.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExternalData))]
 public ExternalData? ExternalData { get => _ExternalData; set => UpdateField(ref _ExternalData, value, nameof(ExternalData)); }

 private ExternalData? _ExternalData;
 /// <summary>
 ///   Print Settings.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PrintSettings))]
 public PrintSettings? PrintSettings { get => _PrintSettings; set => UpdateField(ref _PrintSettings, value, nameof(PrintSettings)); }

 private PrintSettings? _PrintSettings;
 /// <summary>
 ///   User Shapes Reference.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.UserShapesReference))]
 public RelationshipIdType? UserShapesReference { get => _UserShapesReference; set => UpdateField(ref _UserShapesReference, value, nameof(UserShapesReference)); }

 private RelationshipIdType? _UserShapesReference;
 /// <summary>
 ///   Chart Space Extension List.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ChartSpaceExtensionList))]
 public ChartSpaceExtensionList? ChartSpaceExtensionList { get => _ChartSpaceExtensionList; set => UpdateField(ref _ChartSpaceExtensionList, value, nameof(ChartSpaceExtensionList)); }

 private ChartSpaceExtensionList? _ChartSpaceExtensionList;
}