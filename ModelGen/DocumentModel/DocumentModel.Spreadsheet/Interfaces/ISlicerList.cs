namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerList Class.
/// </summary>
public interface ISlicerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISlicerRef>? SlicerRefs { get ; set; }
  
}
