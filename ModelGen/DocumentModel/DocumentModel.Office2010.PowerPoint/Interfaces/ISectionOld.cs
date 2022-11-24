namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SectionOld Class.
/// </summary>
public interface ISectionOld // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// slideIdLst, this property is only available in Office 2010 and later.
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.UInt32Value>? SlideIdList { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
