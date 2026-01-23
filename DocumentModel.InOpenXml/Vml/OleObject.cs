using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;
/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject : ModelElement<DXVO.OleObject>, IEmbeddedObjectContent
{
    /// <summary>
    ///   OLE Object Type
    /// </summary>
    public OleKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private OleKind? _Type;
    /// <summary>
    ///   OLE Object Application
    /// </summary>
    public string? ProgId { get => _ProgId; set => UpdateField(ref _ProgId, value, nameof(ProgId)); }

    private string? _ProgId;
    /// <summary>
    ///   OLE Object Shape
    /// </summary>
    public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

    private string? _ShapeId;
    /// <summary>
    ///   OLE Object Representation
    /// </summary>
    public OleDrawAspectKind? DrawAspect { get => _DrawAspect; set => UpdateField(ref _DrawAspect, value, nameof(DrawAspect)); }

    private OleDrawAspectKind? _DrawAspect;
    /// <summary>
    ///   OLE Object Unique ID
    /// </summary>
    public string? ObjectId { get => _ObjectId; set => UpdateField(ref _ObjectId, value, nameof(ObjectId)); }

    private string? _ObjectId;
    /// <summary>
    ///   Relationship
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   OLE Update Mode
    /// </summary>
    public OleUpdateMode? UpdateMode { get => _UpdateMode; set => UpdateField(ref _UpdateMode, value, nameof(UpdateMode)); }

    private OleUpdateMode? _UpdateMode;
    /// <summary>
    ///   Embedded Object Alternate Image Request.
    /// </summary>
    public string? LinkType { get => _LinkType; set => UpdateField(ref _LinkType, value, nameof(LinkType)); }

    private string? _LinkType;
    /// <summary>
    ///   Embedded Object Cannot Be Refreshed.
    /// </summary>
    public string? LockedField { get => _LockedField; set => UpdateField(ref _LockedField, value, nameof(LockedField)); }

    private string? _LockedField;
    /// <summary>
    ///   WordprocessingML Field Switches.
    /// </summary>
    public string? FieldCodes { get => _FieldCodes; set => UpdateField(ref _FieldCodes, value, nameof(FieldCodes)); }

    private string? _FieldCodes;
}