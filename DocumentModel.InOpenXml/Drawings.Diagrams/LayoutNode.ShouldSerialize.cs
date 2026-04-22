namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class LayoutNode
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeStyleLabel() => !String.IsNullOrEmpty(StyleLabel);
  public bool ShouldSerializeChildOrder() => ChildOrder is not null;
  public bool ShouldSerializeMoveWith() => !String.IsNullOrEmpty(MoveWith);
  public bool ShouldSerializeAlgorithm() => Algorithm is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializePresentationOf() => PresentationOf is not null;
  public bool ShouldSerializeConstraints() => Constraints is not null;
  public bool ShouldSerializeRuleList() => RuleList is not null;
  public bool ShouldSerializeVariableList() => VariableList is not null;
  public bool ShouldSerializeForEach() => ForEach is not null;
  public bool ShouldSerializeChildLayoutNode() => ChildLayoutNode is not null;
  public bool ShouldSerializeChoose() => Choose is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
