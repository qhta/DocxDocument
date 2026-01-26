namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the position properties for a table in a Wordprocessing document.
/// This class provides properties for specifying distances from text, anchor settings, and alignment, enabling precise control over table placement and layout within the document.
/// </summary>
[OpenXmlType(typeof(DXW.TablePositionProperties))]
public partial class TablePositionProperties : ModelElement<DXW.TablePositionProperties>
{
 /// <summary>
 /// Distance from the left edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.LeftFromText))]
 /// <summary>
 /// Distance from the left edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int16? LeftFromText { get => _LeftFromText; set => UpdateField(ref _LeftFromText, value, nameof(LeftFromText)); }

 private Int16? _LeftFromText;
 /// <summary>
 /// Distance from the right edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.RightFromText))]
 /// <summary>
 /// Distance from the right edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int16? RightFromText { get => _RightFromText; set => UpdateField(ref _RightFromText, value, nameof(RightFromText)); }

 private Int16? _RightFromText;
 /// <summary>
 /// Distance from the top edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TopFromText))]
 /// <summary>
 /// Distance from the top edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int16? TopFromText { get => _TopFromText; set => UpdateField(ref _TopFromText, value, nameof(TopFromText)); }

 private Int16? _TopFromText;
 /// <summary>
 /// Distance from the bottom edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.BottomFromText))]
 /// <summary>
 /// Distance from the bottom edge of the table to the surrounding text.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int16? BottomFromText { get => _BottomFromText; set => UpdateField(ref _BottomFromText, value, nameof(BottomFromText)); }

 private Int16? _BottomFromText;
 /// <summary>
 /// Table vertical anchor, specifying the reference point for vertical positioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.VerticalAnchor))]
 /// <summary>
 /// Table vertical anchor, specifying the reference point for vertical positioning.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public VerticalAnchorKind? VerticalAnchor { get => _VerticalAnchor; set => UpdateField(ref _VerticalAnchor, value, nameof(VerticalAnchor)); }

 private VerticalAnchorKind? _VerticalAnchor;
 /// <summary>
 /// Table horizontal anchor, specifying the reference point for horizontal positioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.HorizontalAnchor))]
 /// <summary>
 /// Table horizontal anchor, specifying the reference point for horizontal positioning.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public HorizontalAnchorKind? HorizontalAnchor { get => _HorizontalAnchor; set => UpdateField(ref _HorizontalAnchor, value, nameof(HorizontalAnchor)); }

 private HorizontalAnchorKind? _HorizontalAnchor;
 /// <summary>
 /// Relative horizontal alignment from anchor, specifying how the table is aligned horizontally relative to its anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionXAlignment))]
 /// <summary>
 /// Relative horizontal alignment from anchor, specifying how the table is aligned horizontally relative to its anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public HorizontalAlignmentKind? TablePositionXAlignment { get => _TablePositionXAlignment; set => UpdateField(ref _TablePositionXAlignment, value, nameof(TablePositionXAlignment)); }

 private HorizontalAlignmentKind? _TablePositionXAlignment;
 /// <summary>
 /// Absolute horizontal distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionX))]
 /// <summary>
 /// Absolute horizontal distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int32? TablePositionX { get => _TablePositionX; set => UpdateField(ref _TablePositionX, value, nameof(TablePositionX)); }

 private Int32? _TablePositionX;
 /// <summary>
 /// Relative vertical alignment from anchor, specifying how the table is aligned vertically relative to its anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionYAlignment))]
 /// <summary>
 /// Relative vertical alignment from anchor, specifying how the table is aligned vertically relative to its anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public VerticalAlignmentKind? TablePositionYAlignment { get => _TablePositionYAlignment; set => UpdateField(ref _TablePositionYAlignment, value, nameof(TablePositionYAlignment)); }

 private VerticalAlignmentKind? _TablePositionYAlignment;
 /// <summary>
 /// Absolute vertical distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TablePositionProperties.TablePositionY))]
 /// <summary>
 /// Absolute vertical distance from anchor, specifying the offset from the anchor point.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TablePositionProperties))]
 public Int32? TablePositionY { get => _TablePositionY; set => UpdateField(ref _TablePositionY, value, nameof(TablePositionY)); }

 private Int32? _TablePositionY;
}