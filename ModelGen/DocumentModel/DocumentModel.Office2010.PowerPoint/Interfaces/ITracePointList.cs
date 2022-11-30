namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the TracePointList Class.
/// </summary>
public interface ITracePointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.PowerPoint.ITracePoint>? TracePoints { get ; set; }
  
}
