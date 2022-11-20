namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the ModelRelationship Class.
/// </summary>
public interface IModelRelationship // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// fromTable, this property is only available in Office 2013 and later.
  /// </summary>
  public string? FromTable { get ; set; }
  
  /// <summary>
  /// fromColumn, this property is only available in Office 2013 and later.
  /// </summary>
  public string? FromColumn { get ; set; }
  
  /// <summary>
  /// toTable, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ToTable { get ; set; }
  
  /// <summary>
  /// toColumn, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ToColumn { get ; set; }
  
}
