namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Rule
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeFor() => For is not null;
  public bool ShouldSerializeForName() => !String.IsNullOrEmpty(ForName);
  public bool ShouldSerializePointType() => PointType is not null;
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeFact() => Fact is not null;
  public bool ShouldSerializeMax() => Max is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
