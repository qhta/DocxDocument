namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the position properties for a table in a Wordprocessing document.
/// This class provides properties for specifying distances from text, anchor settings, and alignment, enabling precise control over table placement and layout within the document.
/// </summary>
[OpenXmlType(typeof(DXW.TablePositionProperties))]
[DataContract]
[XmlRoot("TablePositionProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class TablePositionProperties : ModelElement<DXW.TablePositionProperties>
{
 /// <summary>
 /// Distance from the left edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.LeftFromText))]
 public Int16? LeftFromText { get => _LeftFromText; set => UpdateField(ref _LeftFromText, value, nameof(LeftFromText)); }
 private Int16? _LeftFromText;

 /// <summary>
 /// Distance from the right edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.RightFromText))]
 public Int16? RightFromText { get => _RightFromText; set => UpdateField(ref _RightFromText, value, nameof(RightFromText)); }
 private Int16? _RightFromText;

 /// <summary>
 /// Distance from the top edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TopFromText))]
 public Int16? TopFromText { get => _TopFromText; set => UpdateField(ref _TopFromText, value, nameof(TopFromText)); }
 private Int16? _TopFromText;

 /// <summary>
 /// Distance from the bottom edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.BottomFromText))]
 public Int16? BottomFromText { get => _BottomFromText; set => UpdateField(ref _BottomFromText, value, nameof(BottomFromText)); }
 private Int16? _BottomFromText;

 /// <summary>
 /// Table vertical anchor, specifying the reference point for vertical positioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.VerticalAnchor))]
 public VerticalAnchor? VerticalAnchor { get => _VerticalAnchor; set => UpdateField(ref _VerticalAnchor, value, nameof(VerticalAnchor)); }
 private VerticalAnchor? _VerticalAnchor;

 /// <summary>
 /// Table horizontal anchor, specifying the reference point for horizontal positioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.HorizontalAnchor))]
 public HorizontalAnchor? HorizontalAnchor { get => _HorizontalAnchor; set => UpdateField(ref _HorizontalAnchor, value, nameof(HorizontalAnchor)); }
 private HorizontalAnchor? _HorizontalAnchor;

 /// <summary>
 /// Relative horizontal alignment from anchor, specifying how the table is aligned horizontally relative to its anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionXAlignment))]
 public HorizontalAlignment? TablePositionXAlignment { get => _TablePositionXAlignment; set => UpdateField(ref _TablePositionXAlignment, value, nameof(TablePositionXAlignment)); }
 private HorizontalAlignment? _TablePositionXAlignment;

 /// <summary>
 /// Absolute horizontal distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionX))]
 public Int32? TablePositionX { get => _TablePositionX; set => UpdateField(ref _TablePositionX, value, nameof(TablePositionX)); }
 private Int32? _TablePositionX;

 /// <summary>
 /// Relative vertical alignment from anchor, specifying how the table is aligned vertically relative to its anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionYAlignment))]
 public VerticalAlignment? TablePositionYAlignment { get => _TablePositionYAlignment; set => UpdateField(ref _TablePositionYAlignment, value, nameof(TablePositionYAlignment)); }
 private VerticalAlignment? _TablePositionYAlignment;

 /// <summary>
 /// Absolute vertical distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionY))]
 public Int32? TablePositionY { get => _TablePositionY; set => UpdateField(ref _TablePositionY, value, nameof(TablePositionY)); }
 private Int32? _TablePositionY;
}