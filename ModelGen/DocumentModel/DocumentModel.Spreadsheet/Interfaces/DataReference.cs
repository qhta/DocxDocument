namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation Reference.
/// </summary>
public interface DataReference // : System.Boolean
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
  /// relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
}
