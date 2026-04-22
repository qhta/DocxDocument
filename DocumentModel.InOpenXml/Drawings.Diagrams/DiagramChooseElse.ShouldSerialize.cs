namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class DiagramChooseElse
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeAlgorithm() => Algorithm is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializePresentationOf() => PresentationOf is not null;
  public bool ShouldSerializeConstraints() => Constraints is not null;
  public bool ShouldSerializeRuleList() => RuleList is not null;
  public bool ShouldSerializeForEach() => ForEach is not null;
  public bool ShouldSerializeLayoutNode() => LayoutNode is not null;
  public bool ShouldSerializeChoose() => Choose is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
