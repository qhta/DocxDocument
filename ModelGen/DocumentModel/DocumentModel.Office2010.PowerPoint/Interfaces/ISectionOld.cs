namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SectionOld Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IExtensionList))]
public interface ISectionOld // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// slideIdLst, this property is only available in Office 2010 and later.
  /// </summary>
  public List<uint>? SlideIdList { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IExtensionList? ExtensionList { get ; set; }
  
}
