namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Slicers Class.
/// </summary>
public interface ISlicers // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ISlicer>? Slicers { get ; set; }
  
}
