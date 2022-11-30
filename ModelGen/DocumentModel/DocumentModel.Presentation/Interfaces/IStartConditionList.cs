namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StartConditionList Class.
/// </summary>
public interface IStartConditionList // : DocumentModel.Presentation.ITimeListTimeConditionalListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ICondition>? Conditions { get ; set; }
  
}
