namespace DocumentModel.Drawings;

/// <summary>
/// Rule List.
/// </summary>
public interface RuleList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Rule>? Rules { get ; set; }
  
}
