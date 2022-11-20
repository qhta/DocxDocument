namespace DocumentModel.Office2016.ExcelAc;

/// <summary>
/// Defines the CalculatedTimeColumn Class.
/// </summary>
public interface ICalculatedTimeColumn // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// columnName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ColumnName { get ; set; }
  
  /// <summary>
  /// columnId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? ColumnId { get ; set; }
  
  /// <summary>
  /// contentType, this property is only available in Office 2016 and later.
  /// </summary>
  public ModelTimeGroupingContentType? ContentType { get ; set; }
  
  /// <summary>
  /// isSelected, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? IsSelected { get ; set; }
  
}
