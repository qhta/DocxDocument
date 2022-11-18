namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DbCommand Class.
/// </summary>
public interface IDbCommand // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// text, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Text { get ; set; }
  
}
