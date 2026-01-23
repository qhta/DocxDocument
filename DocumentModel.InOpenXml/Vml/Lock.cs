namespace DocumentModel.Vml;
/// <summary>
///   Defines the Lock Class.
/// </summary>
public partial class Lock : ModelElement<DXVO.Lock>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Position Lock
    /// </summary>
    public bool? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private bool? _Position;
    /// <summary>
    ///   Selection Lock
    /// </summary>
    public bool? Selection { get => _Selection; set => UpdateField(ref _Selection, value, nameof(Selection)); }

    private bool? _Selection;
    /// <summary>
    ///   Grouping Lock
    /// </summary>
    public bool? Grouping { get => _Grouping; set => UpdateField(ref _Grouping, value, nameof(Grouping)); }

    private bool? _Grouping;
    /// <summary>
    ///   Ungrouping Lock
    /// </summary>
    public bool? Ungrouping { get => _Ungrouping; set => UpdateField(ref _Ungrouping, value, nameof(Ungrouping)); }

    private bool? _Ungrouping;
    /// <summary>
    ///   Rotation Lock
    /// </summary>
    public bool? Rotation { get => _Rotation; set => UpdateField(ref _Rotation, value, nameof(Rotation)); }

    private bool? _Rotation;
    /// <summary>
    ///   Cropping Lock
    /// </summary>
    public bool? Cropping { get => _Cropping; set => UpdateField(ref _Cropping, value, nameof(Cropping)); }

    private bool? _Cropping;
    /// <summary>
    ///   Vertices Lock
    /// </summary>
    public bool? Verticies { get => _Verticies; set => UpdateField(ref _Verticies, value, nameof(Verticies)); }

    private bool? _Verticies;
    /// <summary>
    ///   Handles Lock
    /// </summary>
    public bool? AdjustHandles { get => _AdjustHandles; set => UpdateField(ref _AdjustHandles, value, nameof(AdjustHandles)); }

    private bool? _AdjustHandles;
    /// <summary>
    ///   Text Lock
    /// </summary>
    public bool? TextLock { get => _TextLock; set => UpdateField(ref _TextLock, value, nameof(TextLock)); }

    private bool? _TextLock;
    /// <summary>
    ///   Aspect Ratio Lock
    /// </summary>
    public bool? AspectRatio { get => _AspectRatio; set => UpdateField(ref _AspectRatio, value, nameof(AspectRatio)); }

    private bool? _AspectRatio;
    /// <summary>
    ///   AutoShape Type Lock
    /// </summary>
    public bool? ShapeType { get => _ShapeType; set => UpdateField(ref _ShapeType, value, nameof(ShapeType)); }

    private bool? _ShapeType;
}