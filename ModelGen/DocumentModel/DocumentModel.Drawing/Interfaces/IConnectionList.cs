namespace DocumentModel.Drawing;

/// <summary>
/// Connection List.
/// </summary>
public interface IConnectionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConnection>? Connections { get ; set; }
  
}
