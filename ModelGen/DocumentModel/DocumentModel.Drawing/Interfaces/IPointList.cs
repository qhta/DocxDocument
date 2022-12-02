namespace DocumentModel.Drawing;

/// <summary>
/// Point List.
/// </summary>
public interface IPointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPoint>? Points { get ; set; }
  
}
