namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class Constraint
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeFor() => For is not null;
  public bool ShouldSerializeForName() => !String.IsNullOrEmpty(ForName);
  public bool ShouldSerializePointType() => PointType is not null;
  public bool ShouldSerializeReferenceType() => ReferenceType is not null;
  public bool ShouldSerializeReferenceFor() => ReferenceFor is not null;
  public bool ShouldSerializeReferenceForName() => !String.IsNullOrEmpty(ReferenceForName);
  public bool ShouldSerializeReferencePointType() => ReferencePointType is not null;
  public bool ShouldSerializeOperator() => Operator is not null;
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeFact() => Fact is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
