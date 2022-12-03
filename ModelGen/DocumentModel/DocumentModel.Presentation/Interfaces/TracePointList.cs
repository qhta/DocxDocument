namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TracePointList Class.
/// </summary>
public interface TracePointList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TracePoint>? TracePoints { get ; set; }
  
}
