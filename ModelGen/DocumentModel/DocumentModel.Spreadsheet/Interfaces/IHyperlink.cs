namespace DocumentModel.Spreadsheet;

/// <summary>
/// Hyperlink.
/// </summary>
public interface IHyperlink // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Location
  /// </summary>
  public String? Location { get ; set; }
  
  /// <summary>
  /// Tool Tip
  /// </summary>
  public String? Tooltip { get ; set; }
  
  /// <summary>
  /// Display String
  /// </summary>
  public String? Display { get ; set; }
  
}
