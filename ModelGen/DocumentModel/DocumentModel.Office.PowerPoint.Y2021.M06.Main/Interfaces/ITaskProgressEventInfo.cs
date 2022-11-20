namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public interface ITaskProgressEventInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public int? Val { get ; set; }
  
}
