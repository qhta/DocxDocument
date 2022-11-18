namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CustomFilter Class.
/// </summary>
public interface ICustomFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public FilterOperator? Operator { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}
