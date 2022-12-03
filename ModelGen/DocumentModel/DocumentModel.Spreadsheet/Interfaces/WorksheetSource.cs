namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetSource Class.
/// </summary>
public interface WorksheetSource // : System.Boolean
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public String? Sheet { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
}
