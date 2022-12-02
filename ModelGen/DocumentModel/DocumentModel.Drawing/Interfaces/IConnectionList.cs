namespace DocumentModel.Drawing;

/// <summary>
/// Connection List.
/// </summary>
public interface IConnectionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IConnection>? Connections { get ; set; }
  
}
