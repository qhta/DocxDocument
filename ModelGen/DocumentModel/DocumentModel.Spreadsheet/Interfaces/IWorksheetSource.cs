namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetSource Class.
/// </summary>
public interface IWorksheetSource // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public System.String? Sheet { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
