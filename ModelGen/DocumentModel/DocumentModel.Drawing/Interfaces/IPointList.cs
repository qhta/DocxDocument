namespace DocumentModel.Drawing;

/// <summary>
/// Point List.
/// </summary>
public interface IPointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPoint>? Points { get ; set; }
  
}
