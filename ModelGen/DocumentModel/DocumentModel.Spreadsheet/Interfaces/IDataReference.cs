namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation Reference.
/// </summary>
public interface IDataReference // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  /// relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
