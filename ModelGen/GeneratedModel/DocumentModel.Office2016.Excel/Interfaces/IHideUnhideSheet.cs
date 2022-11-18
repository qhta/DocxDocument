namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the HideUnhideSheet Class.
/// </summary>
public interface IHideUnhideSheet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// hide, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hide { get ; set; }
  
}
