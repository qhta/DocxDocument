namespace DocumentModel.Presentation;

/// <summary>
/// Defines the LaserTraceList Class.
/// </summary>
public interface LaserTraceList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TracePointList>? TracePointLists { get ; set; }
  
}
