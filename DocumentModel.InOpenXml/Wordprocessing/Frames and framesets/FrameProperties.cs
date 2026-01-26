namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the properties for a frame in a WordprocessingML document.
///   This class provides properties for drop caps, frame size, padding, text wrapping, positioning, alignment, height rules, and anchor locking, enabling advanced configuration and management of frames within document content.
/// </summary>
[OpenXmlType(typeof(DXW.FrameProperties))]
public partial class FrameProperties : ModelElement<DXW.FrameProperties>
{
 /// <summary>
 ///   Drop cap frame location, specifying the position of the drop cap within the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.DropCap))]
 /// <summary>
 ///   Drop cap frame location, specifying the position of the drop cap within the frame.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public DropCapLocationKind? DropCap { get => _DropCap; set => UpdateField(ref _DropCap, value, nameof(DropCap)); }

 private DropCapLocationKind? _DropCap;
 /// <summary>
 ///   Drop cap vertical height, specified in lines.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Lines))]
 /// <summary>
 ///   Drop cap vertical height, specified in lines.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public Int32? Lines { get => _Lines; set => UpdateField(ref _Lines, value, nameof(Lines)); }

 private Int32? _Lines;
 /// <summary>
 ///   Width of the frame, specified as a string value (e.g., in points or percent).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Width))]
 /// <summary>
 ///   Width of the frame, specified as a string value (e.g., in points or percent).
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public string? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private string? _Width;
 /// <summary>
 ///   Height of the frame, specified as an unsigned integer value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Height))]
 /// <summary>
 ///   Height of the frame, specified as an unsigned integer value.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public UInt32? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private UInt32? _Height;
 /// <summary>
 ///   Vertical padding for the frame, specifying space above and below the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.VerticalSpace))]
 /// <summary>
 ///   Vertical padding for the frame, specifying space above and below the frame.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public string? VerticalSpace { get => _VerticalSpace; set => UpdateField(ref _VerticalSpace, value, nameof(VerticalSpace)); }

 private string? _VerticalSpace;
 /// <summary>
 ///   Horizontal padding for the frame, specifying space to the left and right of the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.HorizontalSpace))]
 /// <summary>
 ///   Horizontal padding for the frame, specifying space to the left and right of the frame.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public string? HorizontalSpace { get => _HorizontalSpace; set => UpdateField(ref _HorizontalSpace, value, nameof(HorizontalSpace)); }

 private string? _HorizontalSpace;
 /// <summary>
 ///   Text wrapping option around the frame, specifying how text flows around the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Wrap))]
 /// <summary>
 ///   Text wrapping option around the frame, specifying how text flows around the frame.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public TextWrappingKind? Wrap { get => _Wrap; set => UpdateField(ref _Wrap, value, nameof(Wrap)); }

 private TextWrappingKind? _Wrap;
 /// <summary>
 ///   Horizontal positioning base for the frame, specifying the reference point for horizontal alignment.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.HorizontalPosition))]
 /// <summary>
 ///   Horizontal positioning base for the frame, specifying the reference point for horizontal alignment.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public HorizontalAnchorKind? HorizontalPosition { get => _HorizontalPosition; set => UpdateField(ref _HorizontalPosition, value, nameof(HorizontalPosition)); }

 private HorizontalAnchorKind? _HorizontalPosition;
 /// <summary>
 ///   Vertical positioning base for the frame, specifying the reference point for vertical alignment.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.VerticalPosition))]
 /// <summary>
 ///   Vertical positioning base for the frame, specifying the reference point for vertical alignment.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public VerticalAnchorKind? VerticalPosition { get => _VerticalPosition; set => UpdateField(ref _VerticalPosition, value, nameof(VerticalPosition)); }

 private VerticalAnchorKind? _VerticalPosition;
 /// <summary>
 ///   Absolute horizontal position of the frame, specified as a string value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.X))]
 /// <summary>
 ///   Absolute horizontal position of the frame, specified as a string value.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public string? X { get => _X; set => UpdateField(ref _X, value, nameof(X)); }

 private string? _X;
 /// <summary>
 ///   Relative horizontal position of the frame, specifying alignment relative to the horizontal anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.XAlign))]
 /// <summary>
 ///   Relative horizontal position of the frame, specifying alignment relative to the horizontal anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public HorizontalAlignmentKind? XAlign { get => _XAlign; set => UpdateField(ref _XAlign, value, nameof(XAlign)); }

 private HorizontalAlignmentKind? _XAlign;
 /// <summary>
 ///   Absolute vertical position of the frame, specified as a string value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Y))]
 /// <summary>
 ///   Absolute vertical position of the frame, specified as a string value.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public string? Y { get => _Y; set => UpdateField(ref _Y, value, nameof(Y)); }

 private string? _Y;
 /// <summary>
 ///   Relative vertical position of the frame, specifying alignment relative to the vertical anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.YAlign))]
 /// <summary>
 ///   Relative vertical position of the frame, specifying alignment relative to the vertical anchor.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public VerticalAlignmentKind? YAlign { get => _YAlign; set => UpdateField(ref _YAlign, value, nameof(YAlign)); }

 private VerticalAlignmentKind? _YAlign;
 /// <summary>
 ///   Height rule for the frame, specifying how the frame height is determined.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.HeightType))]
 /// <summary>
 ///   Height rule for the frame, specifying how the frame height is determined.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public HeightRuleKind? HeightType { get => _HeightType; set => UpdateField(ref _HeightType, value, nameof(HeightType)); }

 private HeightRuleKind? _HeightType;
 /// <summary>
 ///   Indicates whether the frame anchor is locked to the paragraph, preventing movement.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.AnchorLock))]
 /// <summary>
 ///   Indicates whether the frame anchor is locked to the paragraph, preventing movement.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FrameProperties))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
}