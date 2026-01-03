namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Rule List.
/// </summary>
public interface RuleList: IModelElement
{
  public Collection<Rule>? Rules { get; set; }
}