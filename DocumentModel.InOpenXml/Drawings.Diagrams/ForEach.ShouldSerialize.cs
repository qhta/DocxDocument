namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ForEach
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeReference() => !String.IsNullOrEmpty(Reference);
  public bool ShouldSerializeAxis() => Axis is not null;
  public bool ShouldSerializePointType() => PointType is not null;
  public bool ShouldSerializeHideLastTrans() => HideLastTrans is not null;
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeCount() => Count is not null;
  public bool ShouldSerializeStep() => Step is not null;
  public bool ShouldSerializeAlgorithm() => Algorithm is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializePresentationOf() => PresentationOf is not null;
  public bool ShouldSerializeConstraints() => Constraints is not null;
  public bool ShouldSerializeRuleList() => RuleList is not null;
  public bool ShouldSerializeChildForEach() => ChildForEach is not null;
  public bool ShouldSerializeLayoutNode() => LayoutNode is not null;
  public bool ShouldSerializeChoose() => Choose is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
