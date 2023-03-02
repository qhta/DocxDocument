namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Rule List.
/// </summary>
public record RuleList
{
  public Collection<Rule>? Rules { get; set; }
}