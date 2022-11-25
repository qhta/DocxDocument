namespace DocumentModel.Spreadsheet;

/// <summary>
/// Hyperlink.
/// </summary>
public interface IHyperlink // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Location
  /// </summary>
  public System.String? Location { get ; set; }
  
  /// <summary>
  /// Tool Tip
  /// </summary>
  public System.String? Tooltip { get ; set; }
  
  /// <summary>
  /// Display String
  /// </summary>
  public System.String? Display { get ; set; }
  
}
