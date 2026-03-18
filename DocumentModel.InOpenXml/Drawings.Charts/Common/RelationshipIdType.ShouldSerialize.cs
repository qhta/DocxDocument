namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class RelationshipIdType
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
}
