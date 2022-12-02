namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ProtectedRanges Class.
/// </summary>
public interface IProtectedRanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IProtectedRange>? ProtectedRanges { get ; set; }
  
}
