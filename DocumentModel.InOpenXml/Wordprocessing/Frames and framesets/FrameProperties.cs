namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the properties for a frame in a WordprocessingML document.
///   This class provides properties for drop caps, frame size, padding, text wrapping, positioning, alignment, height rules, and anchor locking, enabling advanced configuration and management of frames within document content.
/// </summary>
[OpenXmlType(typeof(DXW.FrameProperties))]
[XmlRoot("FrameProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class FrameProperties : ModelElement<DXW.FrameProperties> //, IFrameProperties
{
 /// <summary>
 ///   Drop cap frame location, specifying the position of the drop cap within the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.DropCap))]
 public DropCapLocation? DropCap { get => _dropCap; set => UpdateField(ref _dropCap, value, nameof(DropCap)); }

 private DropCapLocation? _dropCap;
 /// <summary>
 ///   Drop cap vertical height, specified in lines.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Lines))]
 public Int32? DropCapLines { get => _dropCapLines; set => UpdateField(ref _dropCapLines, value, nameof(DropCapLines)); }

 private Int32? _dropCapLines;
 /// <summary>
 ///   Width of the frame, specified as a string value (e.g., in points or percent).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Width))]
 public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private Twips? _Width;
 /// <summary>
 ///   Height of the frame, specified as an unsigned integer value.
 /// </summary>
 [OpenXmlUpdateData(nameof(UpdateOpenXmlHeight))]
 [OpenXmlLoadData(nameof(LoadOpenXmlHeight))]
 public HeightMeasure? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private HeightMeasure? _Height;
 /// <summary>
 /// Updates the height and height type properties of the specified OpenXml element if it is a FrameProperties element.
 /// </summary>
 /// <remarks>If the Height property is set, the method assigns the corresponding height value and height type
 /// to the FrameProperties element. If Height is not set, the height type defaults to Auto.</remarks>
 /// <param name = "element">The OpenXml element to update. Must be of type FrameProperties for height settings to be applied.</param>
 public void UpdateOpenXmlHeight(DX.OpenXmlElement element)
 {
  if (element is DXW.FrameProperties frameProperties && Height != null)
   (frameProperties.Height, frameProperties.HeightType) = Height.ToOpenXml();
 }

 /// <summary>
 /// Loads the height properties from the specified OpenXML element and updates the Height measure accordingly.
 /// </summary>
 /// <remarks>If the height is specified, it is converted to a HeightMeasure object using the appropriate
 /// height type. If no height is specified, the Height property is set to null.</remarks>
 /// <param name = "element">The OpenXML element containing frame properties, which may include height information.</param>
 public void LoadOpenXmlHeight(DX.OpenXmlElement element)
 {
  if (element is DXW.FrameProperties frameProperties && frameProperties.Height != null)
   Height = HeightMeasure.FromOpenXml(frameProperties.Height, frameProperties.HeightType);
 }

 /// <summary>
 ///   Vertical padding for the frame, specifying space above and below the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.VerticalSpace))]
 public Twips? VerticalSpace { get => _VerticalSpace; set => UpdateField(ref _VerticalSpace, value, nameof(VerticalSpace)); }

 private Twips? _VerticalSpace;
 /// <summary>
 ///   Horizontal padding for the frame, specifying space to the left and right of the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.HorizontalSpace))]
 public Twips? HorizontalSpace { get => _HorizontalSpace; set => UpdateField(ref _HorizontalSpace, value, nameof(HorizontalSpace)); }

 private Twips? _HorizontalSpace;
 /// <summary>
 ///   Text wrapping option around the frame, specifying how text flows around the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Wrap))]
 public TextWrapping? Wrap { get => _Wrap; set => UpdateField(ref _Wrap, value, nameof(Wrap)); }

 private TextWrapping? _Wrap;
 /// <summary>
 ///   Horizontal positioning base for the frame, specifying the reference point for horizontal alignment.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.HorizontalPosition))]
 public HorizontalAnchor? HorizontalPosition { get => _HorizontalPosition; set => UpdateField(ref _HorizontalPosition, value, nameof(HorizontalPosition)); }

 private HorizontalAnchor? _HorizontalPosition;
 /// <summary>
 ///   Vertical positioning base for the frame, specifying the reference point for vertical alignment.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.VerticalPosition))]
 public VerticalAnchor? VerticalPosition { get => _VerticalPosition; set => UpdateField(ref _VerticalPosition, value, nameof(VerticalPosition)); }

 private VerticalAnchor? _VerticalPosition;
 /// <summary>
 ///   Absolute horizontal position of the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.X))]
 public Twips? X { get => _X; set => UpdateField(ref _X, value, nameof(X)); }

 private Twips? _X;
 /// <summary>
 ///   Relative horizontal position of the frame, specifying alignment relative to the horizontal anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.XAlign))]
 public HorizontalAlignment? XAlign { get => _XAlign; set => UpdateField(ref _XAlign, value, nameof(XAlign)); }

 private HorizontalAlignment? _XAlign;
 /// <summary>
 ///   Absolute vertical position of the frame.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.Y))]
 public Twips? Y { get => _Y; set => UpdateField(ref _Y, value, nameof(Y)); }

 private Twips? _Y;
 /// <summary>
 ///   Relative vertical position of the frame, specifying alignment relative to the vertical anchor.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.YAlign))]
 public VerticalAlignment? YAlign { get => _YAlign; set => UpdateField(ref _YAlign, value, nameof(YAlign)); }

 private VerticalAlignment? _YAlign;
 /// <summary>
 ///   Indicates whether the frame anchor is locked to the paragraph, preventing movement.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FrameProperties.AnchorLock))]
 public bool? AnchorLock { get => _AnchorLock; set => UpdateField(ref _AnchorLock, value, nameof(AnchorLock)); }

 private bool? _AnchorLock;
}