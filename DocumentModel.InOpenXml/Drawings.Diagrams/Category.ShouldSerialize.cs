namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Category
{
  public bool ShouldSerializeType() => !String.IsNullOrEmpty(Type);
  public bool ShouldSerializePriority() => Priority is not null;
}
