namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Slicers Class.
/// </summary>
public interface ISlicers // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ISlicer>? Slicers { get ; set; }
  
}
