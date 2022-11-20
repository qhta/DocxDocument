namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SetLevel Class.
/// </summary>
public interface ISetLevel // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// hierarchy, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Hierarchy { get ; set; }
  
}
