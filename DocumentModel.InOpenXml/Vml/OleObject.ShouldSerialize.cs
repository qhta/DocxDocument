namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class OleObject
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeProgId() => ProgId is not null;
  public bool ShouldSerializeShapeId() => ShapeId is not null;
  public bool ShouldSerializeDrawAspect() => DrawAspect is not null;
  public bool ShouldSerializeObjectId() => ObjectId is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeUpdateMode() => UpdateMode is not null;
  public bool ShouldSerializeLinkType() => LinkType is not null;
  public bool ShouldSerializeLockedField() => LockedField is not null;
  public bool ShouldSerializeFieldCodes() => FieldCodes is not null;
}
