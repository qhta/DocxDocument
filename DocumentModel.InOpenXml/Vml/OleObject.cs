using DocumentModel.Wordprocessing;
namespace DocumentModel.Vml;
/// <summary>
///   Embedded OLE Object.
/// </summary>
[OpenXmlType(typeof(DXVO.OleObject))]
public partial class OleObject : ModelElement<DXVO.OleObject>, IEmbeddedObjectContent
{
 /// <summary>
 ///   OLE Object Type
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.Type))]
 public OleType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private OleType? _Type;
 /// <summary>
 ///   OLE Object Application
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.ProgId))]
 public string? ProgId { get => _ProgId; set => UpdateField(ref _ProgId, value, nameof(ProgId)); }
 private string? _ProgId;
 /// <summary>
 ///   OLE Object Shape
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.ShapeId))]
 public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }
 private string? _ShapeId;
 /// <summary>
 ///   OLE Object Representation
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.DrawAspect))]
 public OleDrawAspect? DrawAspect { get => _DrawAspect; set => UpdateField(ref _DrawAspect, value, nameof(DrawAspect)); }
 private OleDrawAspect? _DrawAspect;
 /// <summary>
 ///   OLE Object Unique ID
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.ObjectId))]
 public string? ObjectId { get => _ObjectId; set => UpdateField(ref _ObjectId, value, nameof(ObjectId)); }
 private string? _ObjectId;
 /// <summary>
 ///   Relationship
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;
 /// <summary>
 ///   OLE Update Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.UpdateMode))]
 public OleUpdateMode? UpdateMode { get => _UpdateMode; set => UpdateField(ref _UpdateMode, value, nameof(UpdateMode)); }
 private OleUpdateMode? _UpdateMode;
 /// <summary>
 ///   Embedded Object Alternate Image Request.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.LinkType))]
 public string? LinkType { get => _LinkType; set => UpdateField(ref _LinkType, value, nameof(LinkType)); }
 private string? _LinkType;
 /// <summary>
 ///   Embedded Object Cannot Be Refreshed.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.LockedField))]
 public string? LockedField { get => _LockedField; set => UpdateField(ref _LockedField, value, nameof(LockedField)); }
 private string? _LockedField;
 /// <summary>
 ///   WordprocessingML Field Switches.
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.OleObject.FieldCodes))]
 public string? FieldCodes { get => _FieldCodes; set => UpdateField(ref _FieldCodes, value, nameof(FieldCodes)); }
 private string? _FieldCodes;
}