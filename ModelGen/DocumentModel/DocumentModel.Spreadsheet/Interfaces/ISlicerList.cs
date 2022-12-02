namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerList Class.
/// </summary>
public interface ISlicerList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISlicerRef>? SlicerRefs { get ; set; }
  
}
