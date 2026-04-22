namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base class for all TableProperties classes.
/// Contains common properties for table formatting, including alignment, indentation, cell margins, cell spacing, borders, and shading.
/// </summary>
[OpenXmlType(typeof(DXW.TableProperties))]
[XmlRoot("BaseTableProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class BaseTableProperties<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 /// Table alignment, specifying horizontal justification of the table within the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableProperties.TableJustification))]
 public TableRowAlignment? TableJustification { get => _TableJustification; set => UpdateField(ref _TableJustification, value, nameof(TableJustification)); }
 private TableRowAlignment? _TableJustification;

 /// <summary>
 /// Table indent from leading margin, specifying the distance from the document margin to the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableProperties.TableIndentation))]
 public TableMeasure? TableIndentation { get => _TableIndentation; set => UpdateField(ref _TableIndentation, value, nameof(TableIndentation)); }
 private TableMeasure? _TableIndentation;

 /// <summary>
 /// Default cell margin for the table, specifying padding for all table cells.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableCellSpacing))]
 public TableCellMargin? DefaultTableCellMargin { get => _DefaultTableCellMargin; set => UpdateField(ref _DefaultTableCellMargin, value, nameof(DefaultTableCellMargin)); }
 private TableCellMargin? _DefaultTableCellMargin;

 /// <summary>
 /// Cell spacing for the table, specifying the space between adjacent cells.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableProperties.TableCellSpacing))]
 public TableMeasure? TableCellSpacing { get => _TableCellSpacing; set => UpdateField(ref _TableCellSpacing, value, nameof(TableCellSpacing)); }
 private TableMeasure? _TableCellSpacing;

 /// <summary>
 /// Borders for the table, specifying line style, color, and width for table edges.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableProperties.TableBorders))]
 public TableBorders? TableBorders { get => _TableBorders; set => UpdateField(ref _TableBorders, value, nameof(TableBorders)); }
 private TableBorders? _TableBorders;

 /// <summary>
 /// Shading applied to the table, specifying background and pattern formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableProperties.Shading))]
 public Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }
 private Shading? _Shading;
}

/// <summary>
/// Concrete class of BaseTableProperties for the Open XML SDK TableProperties element.
/// </summary>
[XmlRoot("BaseTableProperties", Namespace = "DocumentModel.Wordprocessing")]
public class BaseTableProperties : BaseTableProperties<DXW.TableProperties>
{
 /// <summary>
 /// Initializes a new instance of the BaseTableProperties class.
 /// </summary>
 public BaseTableProperties() : base()
 {
 }
}