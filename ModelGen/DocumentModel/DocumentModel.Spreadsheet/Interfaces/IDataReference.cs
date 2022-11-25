namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation Reference.
/// </summary>
public interface IDataReference // : DocumentModel.ITypedOpenXmlLeafElement
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
  /// relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
