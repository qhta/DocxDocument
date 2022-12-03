namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StartConditionList Class.
/// </summary>
public interface StartConditionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Condition>? Conditions { get ; set; }
  
}
