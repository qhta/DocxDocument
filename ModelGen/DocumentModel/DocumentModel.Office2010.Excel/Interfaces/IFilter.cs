namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the Filter Class.
/// </summary>
public interface IFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}
