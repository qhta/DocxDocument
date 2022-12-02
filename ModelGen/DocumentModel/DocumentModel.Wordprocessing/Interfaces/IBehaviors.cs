namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public interface IBehaviors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<DocPartBehaviorKind>? Behaviors { get ; set; }
  
}
