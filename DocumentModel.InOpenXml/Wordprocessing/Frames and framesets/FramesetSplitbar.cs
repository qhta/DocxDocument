namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties for a frameset splitter in a WordprocessingML document.
/// This class provides properties for splitter width, color, border visibility, and border style, enabling advanced customization of the appearance and behavior of frameset splitters within document layouts.
/// </summary>
[OpenXmlType(typeof(DXW.FramesetSplitbar))]
[XmlRoot("FramesetSplitbar", Namespace = "DocumentModel.Wordprocessing")]
public partial class FramesetSplitbar : ModelElement<DXW.FramesetSplitbar>
{
 /// <summary>
 /// Width of the frameset splitter, specified in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FramesetSplitbar.Width))]
 public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private Twips? _Width;

 /// <summary>
 /// Color of the frameset splitter, specified as an abstract color value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FramesetSplitbar.Color))]
 public DocumentModel.AnyColor? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private DocumentModel.AnyColor? _Color;

 /// <summary>
 /// Indicates whether frameset splitters should not be displayed (no border).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FramesetSplitbar.NoBorder))]
 public bool? NoBorder { get => _NoBorder; set => UpdateField(ref _NoBorder, value, nameof(NoBorder)); }
 private bool? _NoBorder;

 /// <summary>
 /// Indicates whether the frameset splitter uses a flat border style.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FramesetSplitbar.FlatBorders))]
 public bool? FlatBorders { get => _FlatBorders; set => UpdateField(ref _FlatBorders, value, nameof(FlatBorders)); }
 private bool? _FlatBorders;
}