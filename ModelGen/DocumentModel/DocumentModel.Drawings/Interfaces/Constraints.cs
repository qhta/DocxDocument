namespace DocumentModel.Drawings;

/// <summary>
/// Constraint List.
/// </summary>
public interface Constraints // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Constraint>? Constraints { get ; set; }
  
}
