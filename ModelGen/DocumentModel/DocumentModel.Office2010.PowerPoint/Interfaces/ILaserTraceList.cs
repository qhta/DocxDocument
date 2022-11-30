namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the LaserTraceList Class.
/// </summary>
public interface ILaserTraceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.PowerPoint.ITracePointList>? TracePointLists { get ; set; }
  
}
