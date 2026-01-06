namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Rule List.
/// </summary>
public interface RuleList
{
  public Collection<Rule>? Rules { get; set; }
}