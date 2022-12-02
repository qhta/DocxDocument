namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Slicers Class.
/// </summary>
public interface ISlicers // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISlicer>? Slicers { get ; set; }
  
}
