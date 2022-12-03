namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndConditionList Class.
/// </summary>
public interface EndConditionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Condition>? Conditions { get ; set; }
  
}
