namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocPartProperties
{
  public bool ShouldSerializeDocPartName() => DocPartName is not null && ShouldSerialize(DocPartName);
  public bool ShouldSerializeStyleId() => !String.IsNullOrEmpty(StyleId);
  public bool ShouldSerializeCategory() => Category is not null && ShouldSerialize(Category);
  public bool ShouldSerializeDocPartTypes() => DocPartTypes is not null && ShouldSerialize(DocPartTypes);
  public bool ShouldSerializeBehaviors() => Behaviors is not null && ShouldSerialize(Behaviors);
  public bool ShouldSerializeDescription() => !String.IsNullOrEmpty(Description);
  public bool ShouldSerializeDocPartId() => !String.IsNullOrEmpty(DocPartId);
}
