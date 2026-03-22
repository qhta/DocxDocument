namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocPartProperties
{
  public bool ShouldSerializeDocPartName() => DocPartName is not null;
  public bool ShouldSerializeStyleId() => StyleId is not null;
  public bool ShouldSerializeCategory() => Category is not null;
  public bool ShouldSerializeDocPartTypes() => DocPartTypes is not null;
  public bool ShouldSerializeBehaviors() => Behaviors is not null;
  public bool ShouldSerializeDescription() => Description is not null;
  public bool ShouldSerializeDocPartId() => DocPartId is not null;
}
