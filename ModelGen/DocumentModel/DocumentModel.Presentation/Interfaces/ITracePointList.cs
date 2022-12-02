namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TracePointList Class.
/// </summary>
public interface ITracePointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ITracePoint>? TracePoints { get ; set; }
  
}
