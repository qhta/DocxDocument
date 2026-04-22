namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RelationshipType<T> 
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
}
