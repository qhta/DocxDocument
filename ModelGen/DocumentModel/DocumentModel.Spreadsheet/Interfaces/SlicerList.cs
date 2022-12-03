namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerList Class.
/// </summary>
public interface SlicerList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<SlicerRef>? SlicerRefs { get ; set; }
  
}
