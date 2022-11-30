namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerList Class.
/// </summary>
public interface ISlicerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ISlicerRef>? SlicerRefs { get ; set; }
  
}
