namespace DocumentModel.Presentation;

/// <summary>
/// Defines the LaserTraceList Class.
/// </summary>
public interface ILaserTraceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITracePointList>? TracePointLists { get ; set; }
  
}
