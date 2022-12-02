namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SubTimeNodeList Class.
/// </summary>
public interface ISubTimeNodeList // : DocumentModel.Presentation.ITimeTypeListType
{
  public Collection<IParallelTimeNode>? ParallelTimeNodes { get ; set; }
  
  public Collection<ISequenceTimeNode>? SequenceTimeNodes { get ; set; }
  
  public Collection<IExclusiveTimeNode>? ExclusiveTimeNodes { get ; set; }
  
  public Collection<IAnimate>? Animates { get ; set; }
  
  public Collection<IAnimateColor>? AnimateColors { get ; set; }
  
  public Collection<IAnimateEffect>? AnimateEffects { get ; set; }
  
  public Collection<IAnimateMotion>? AnimateMotions { get ; set; }
  
  public Collection<IAnimateRotation>? AnimateRotations { get ; set; }
  
  public Collection<IAnimateScale>? AnimateScales { get ; set; }
  
  public Collection<ICommand>? Commands { get ; set; }
  
  public Collection<ISetBehavior>? SetBehaviors { get ; set; }
  
  public Collection<IAudio>? Audios { get ; set; }
  
  public Collection<IVideo>? Videos { get ; set; }
  
}
