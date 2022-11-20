namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public interface IOutline // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// isCollapsed, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? IsCollapsed { get ; set; }
  
  /// <summary>
  /// level, this property is only available in Office 2016 and later.
  /// </summary>
  public byte? Level { get ; set; }
  
}
