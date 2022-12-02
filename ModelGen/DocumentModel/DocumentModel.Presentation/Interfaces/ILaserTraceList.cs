namespace DocumentModel.Presentation;

/// <summary>
/// Defines the LaserTraceList Class.
/// </summary>
public interface ILaserTraceList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ITracePointList>? TracePointLists { get ; set; }
  
}
