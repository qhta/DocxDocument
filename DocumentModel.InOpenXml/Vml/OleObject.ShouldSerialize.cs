namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class OleObject
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeProgId() => !String.IsNullOrEmpty(ProgId);
  public bool ShouldSerializeShapeId() => !String.IsNullOrEmpty(ShapeId);
  public bool ShouldSerializeDrawAspect() => DrawAspect is not null;
  public bool ShouldSerializeObjectId() => !String.IsNullOrEmpty(ObjectId);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeUpdateMode() => UpdateMode is not null;
  public bool ShouldSerializeLinkType() => !String.IsNullOrEmpty(LinkType);
  public bool ShouldSerializeLockedField() => !String.IsNullOrEmpty(LockedField);
  public bool ShouldSerializeFieldCodes() => !String.IsNullOrEmpty(FieldCodes);
}
