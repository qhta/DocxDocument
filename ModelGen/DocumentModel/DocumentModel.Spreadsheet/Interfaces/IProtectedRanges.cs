namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ProtectedRanges Class.
/// </summary>
public interface IProtectedRanges // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IProtectedRange>? ProtectedRanges { get ; set; }
  
}
