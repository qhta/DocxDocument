namespace DocumentModel.Presentation;

/// <summary>
/// Next Conditions List.
/// </summary>
public interface NextConditionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Condition>? Conditions { get ; set; }
  
}
