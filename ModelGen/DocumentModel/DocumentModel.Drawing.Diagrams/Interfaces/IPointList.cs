namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public interface IPointList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IPoint>? Points { get ; set; }
  
}
