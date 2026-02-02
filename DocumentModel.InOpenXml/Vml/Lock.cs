namespace DocumentModel.Vml;
/// <summary>
///   Defines the Lock Class.
/// </summary>
[OpenXmlType(typeof(DXVO.Lock))]
public partial class Lock : ModelElement<DXVO.Lock>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehavior? _Extension;
 /// <summary>
 ///   Position Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Position))]
 public bool? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private bool? _Position;
 /// <summary>
 ///   Selection Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Selection))]
 public bool? Selection { get => _Selection; set => UpdateField(ref _Selection, value, nameof(Selection)); }

 private bool? _Selection;
 /// <summary>
 ///   Grouping Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Grouping))]
 public bool? Grouping { get => _Grouping; set => UpdateField(ref _Grouping, value, nameof(Grouping)); }

 private bool? _Grouping;
 /// <summary>
 ///   Ungrouping Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Ungrouping))]
 public bool? Ungrouping { get => _Ungrouping; set => UpdateField(ref _Ungrouping, value, nameof(Ungrouping)); }

 private bool? _Ungrouping;
 /// <summary>
 ///   Rotation Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Rotation))]
 public bool? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

 private bool? _Rotation;
 /// <summary>
 ///   Cropping Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Cropping))]
 public bool? Cropping { get => _Cropping; set => UpdateField(ref _Cropping, value, nameof(Cropping)); }

 private bool? _Cropping;
 /// <summary>
 ///   Vertices Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.Verticies))]
 public bool? Verticies { get => _Verticies; set => UpdateField(ref _Verticies, value, nameof(Verticies)); }

 private bool? _Verticies;
 /// <summary>
 ///   Handles Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.AdjustHandles))]
 public bool? AdjustHandles { get => _AdjustHandles; set => UpdateField(ref _AdjustHandles, value, nameof(AdjustHandles)); }

 private bool? _AdjustHandles;
 /// <summary>
 ///   Text Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.TextLock))]
 public bool? TextLock { get => _TextLock; set => UpdateField(ref _TextLock, value, nameof(TextLock)); }

 private bool? _TextLock;
 /// <summary>
 ///   Aspect Ratio Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.AspectRatio))]
 public bool? AspectRatio { get => _AspectRatio; set => UpdateField(ref _AspectRatio, value, nameof(AspectRatio)); }

 private bool? _AspectRatio;
 /// <summary>
 ///   AutoShape Type Lock
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.Lock.ShapeType))]
 public bool? ShapeType { get => _ShapeType; set => UpdateField(ref _ShapeType, value, nameof(ShapeType)); }

 private bool? _ShapeType;
}