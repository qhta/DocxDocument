namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public interface IBehaviors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DocPartBehaviorKind>? Behaviors { get ; set; }
  
}
