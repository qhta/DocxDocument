namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public partial interface RuleList
{
  public Collection<DocumentModel.Drawings.Diagrams.Rule>? Rules { get; set; }
  
}
