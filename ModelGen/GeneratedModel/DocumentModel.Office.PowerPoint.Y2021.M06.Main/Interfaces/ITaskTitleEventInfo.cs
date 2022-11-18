namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public interface ITaskTitleEventInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}
