namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public interface ISingleCellTablePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.ISingleXmlCells? SingleXmlCells { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
