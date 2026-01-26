namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Picture Fill.
/// </summary>
[OpenXmlType(typeof(DXDP.BlipFill))]
public partial class BlipFill : ModelElement<DXDP.BlipFill>
{
 /// <summary>
 ///   DPI Setting
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.BlipFill.Dpi))]
 /// <summary>
 ///   DPI Setting
 /// </summary>
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public UInt32? Dpi { get => _Dpi; set => UpdateField(ref _Dpi, value, nameof(Dpi)); }

 private UInt32? _Dpi;
 /// <summary>
 ///   Rotate With Shape
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.BlipFill.RotateWithShape))]
 /// <summary>
 ///   Rotate With Shape
 /// </summary>
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public bool? RotateWithShape { get => _RotateWithShape; set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape)); }

 private bool? _RotateWithShape;
 /// <summary>
 ///   Blip.
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.BlipFill.Blip))]
 /// <summary>
 ///   Blip.
 /// </summary>
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public Blip? Blip { get => _Blip; set => UpdateField(ref _Blip, value, nameof(Blip)); }

 private Blip? _Blip;
 /// <summary>
 ///   Source Rectangle.
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.BlipFill.SourceRectangle))]
 /// <summary>
 ///   Source Rectangle.
 /// </summary>
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public RelativeRectangleType? SourceRectangle { get => _SourceRectangle; set => UpdateField(ref _SourceRectangle, value, nameof(SourceRectangle)); }

 private RelativeRectangleType? _SourceRectangle;
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public Tile? Tile { get => _Tile; set => UpdateField(ref _Tile, value, nameof(Tile)); }

 private Tile? _Tile;
 [OpenXmlElement(typeof(DXDP.BlipFill))]
 public Stretch? Stretch { get => _Stretch; set => UpdateField(ref _Stretch, value, nameof(Stretch)); }

 private Stretch? _Stretch;
}