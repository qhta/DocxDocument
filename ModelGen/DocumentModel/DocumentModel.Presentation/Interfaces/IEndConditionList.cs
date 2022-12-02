namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndConditionList Class.
/// </summary>
public interface IEndConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public Collection<ICondition>? Conditions { get ; set; }
  
}
