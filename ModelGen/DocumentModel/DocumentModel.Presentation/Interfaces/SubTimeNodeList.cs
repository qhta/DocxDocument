namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SubTimeNodeList Class.
/// </summary>
public interface SubTimeNodeList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ParallelTimeNode>? ParallelTimeNodes { get ; set; }
  
  public Collection<SequenceTimeNode>? SequenceTimeNodes { get ; set; }
  
  public Collection<ExclusiveTimeNode>? ExclusiveTimeNodes { get ; set; }
  
  public Collection<Animate>? Animates { get ; set; }
  
  public Collection<AnimateColor>? AnimateColors { get ; set; }
  
  public Collection<AnimateEffect>? AnimateEffects { get ; set; }
  
  public Collection<AnimateMotion>? AnimateMotions { get ; set; }
  
  public Collection<AnimateRotation>? AnimateRotations { get ; set; }
  
  public Collection<AnimateScale>? AnimateScales { get ; set; }
  
  public Collection<Command>? Commands { get ; set; }
  
  public Collection<SetBehavior>? SetBehaviors { get ; set; }
  
  public Collection<Audio>? Audios { get ; set; }
  
  public Collection<Video>? Videos { get ; set; }
  
}
