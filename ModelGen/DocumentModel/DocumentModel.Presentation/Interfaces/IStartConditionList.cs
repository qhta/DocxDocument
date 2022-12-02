namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StartConditionList Class.
/// </summary>
public interface IStartConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public Collection<ICondition>? Conditions { get ; set; }
  
}
