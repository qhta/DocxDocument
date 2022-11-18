namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetSource Class.
/// </summary>
public interface IWorksheetSource // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public string? Sheet { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
