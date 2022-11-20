namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineStyleElements))]
public interface ITimelineStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// TimelineStyleElements.
  /// </summary>
  public ITimelineStyleElements? TimelineStyleElements { get ; set; }
  
}
