namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the Section Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ISectionSlideIdList))]
public class Section: ISection
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// SectionSlideIdList.
  /// </summary>
  public ISectionSlideIdList? SectionSlideIdList
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
