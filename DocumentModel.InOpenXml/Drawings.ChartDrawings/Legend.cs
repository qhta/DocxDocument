using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the legend that identifies data series and categories in a chart visualization.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.Legend))]
[XmlRoot("Legend", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Legend : ModelElement<DXO16DCD.Legend> //: ExtendableElement
{
 /// <summary>
 /// Specifies the pos.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Legend.Pos))]
 public SidePos? Pos { get => _Pos; set => UpdateField(ref _Pos, value, nameof(Pos)); }

 private SidePos? _Pos;
 /// <summary>
 /// Specifies the align.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Legend.Align))]
 public PosAlign? Align { get => _Align; set => UpdateField(ref _Align, value, nameof(Align)); }

 private PosAlign? _Align;
 /// <summary>
 /// Specifies the overlay.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Legend.Overlay))]
 public bool? Overlay { get => _Overlay; set => UpdateField(ref _Overlay, value, nameof(Overlay)); }

 private bool? _Overlay;
 /// <summary>
 /// Specifies the shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Legend.ShapeProperties))]
 public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

 private ShapeProperties? _ShapeProperties;
 /// <summary>
 /// Specifies the tx pr text body.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Legend.TxPrTextBody))]
 public TxPrTextBody? TxPrTextBody { get => _TxPrTextBody; set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody)); }

 private TxPrTextBody? _TxPrTextBody;
}