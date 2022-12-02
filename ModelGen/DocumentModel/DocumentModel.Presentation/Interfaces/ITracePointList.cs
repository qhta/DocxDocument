namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TracePointList Class.
/// </summary>
public interface ITracePointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITracePoint>? TracePoints { get ; set; }
  
}
