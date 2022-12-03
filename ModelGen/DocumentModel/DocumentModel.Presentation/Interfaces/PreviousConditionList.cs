namespace DocumentModel.Presentation;

/// <summary>
/// Previous Conditions List.
/// </summary>
public interface PreviousConditionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Condition>? Conditions { get ; set; }
  
}
