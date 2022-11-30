namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SubTimeNodeList Class.
/// </summary>
public interface ISubTimeNodeList // : DocumentModel.Presentation.ITimeTypeListType
{
  public DocumentModel.Presentation.IParallelTimeNode? ParallelTimeNode { get ; set; }
  
  public DocumentModel.Presentation.ISequenceTimeNode? SequenceTimeNode { get ; set; }
  
  public DocumentModel.Presentation.IExclusiveTimeNode? ExclusiveTimeNode { get ; set; }
  
  public DocumentModel.Presentation.IAnimate? Animate { get ; set; }
  
  public DocumentModel.Presentation.IAnimateColor? AnimateColor { get ; set; }
  
  public DocumentModel.Presentation.IAnimateEffect? AnimateEffect { get ; set; }
  
  public DocumentModel.Presentation.IAnimateMotion? AnimateMotion { get ; set; }
  
  public DocumentModel.Presentation.IAnimateRotation? AnimateRotation { get ; set; }
  
  public DocumentModel.Presentation.IAnimateScale? AnimateScale { get ; set; }
  
  public DocumentModel.Presentation.ICommand? Command { get ; set; }
  
  public DocumentModel.Presentation.ISetBehavior? SetBehavior { get ; set; }
  
  public DocumentModel.Presentation.IAudio? Audio { get ; set; }
  
  public DocumentModel.Presentation.IVideo? Video { get ; set; }
  
}
