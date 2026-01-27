namespace DocumentModel.Packaging;

public partial class ReferenceRelationship<T>
{
  public bool ShouldSerializeRelationshipType() => RelationshipType is not null;
  public bool ShouldSerializeIsExternal() => IsExternal == true;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
