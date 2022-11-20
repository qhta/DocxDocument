namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ApplicationNonVisualDrawingPropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IMedia))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IModificationId))]
public class ApplicationNonVisualDrawingPropertiesExtension: IApplicationNonVisualDrawingPropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
