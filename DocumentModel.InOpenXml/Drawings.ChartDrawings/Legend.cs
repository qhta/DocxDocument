using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the legend that identifies data series and categories in a chart visualization.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.Legend))]
[DataContract]
[XmlRoot("Legend", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Legend: ModelElement<DXO16DCD.Legend> //: ExtendableElement
{
  /// <summary>
  /// Specifies the pos.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Legend.Pos))]
  public SidePos? Pos
  {
    get => _Pos ??= GetProperty<SidePos?>(GetUpdatableElement()?.Pos);
    set => UpdateField(ref _Pos, value, nameof(Pos));
  }

  private SidePos? _Pos;

  /// <summary>
  /// Specifies the align.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Legend.Align))]
  public PosAlign? Align
  {
    get => _Align ??= GetProperty<PosAlign?>(GetUpdatableElement()?.Align);
    set => UpdateField(ref _Align, value, nameof(Align));
  }

  private PosAlign? _Align;

  /// <summary>
  /// Specifies the overlay.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Legend.Overlay))]
  public bool? Overlay
  {
    get => _Overlay ??= GetProperty<bool?>(GetUpdatableElement()?.Overlay);
    set => UpdateField(ref _Overlay, value, nameof(Overlay));
  }

  private bool? _Overlay;

  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Legend.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetProperty<ShapeProperties?>(GetUpdatableElement()?.ShapeProperties);
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Legend.TxPrTextBody))]
  public TxPrTextBody? TxPrTextBody
  {
    get => _TxPrTextBody ??= GetProperty<TxPrTextBody?>(GetUpdatableElement()?.TxPrTextBody);
    set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody));
  }

  private TxPrTextBody? _TxPrTextBody;
}