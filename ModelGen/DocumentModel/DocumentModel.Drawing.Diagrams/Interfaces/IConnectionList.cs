namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Connection List.
/// </summary>
public interface IConnectionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IConnection>? Connections { get ; set; }
  
}
