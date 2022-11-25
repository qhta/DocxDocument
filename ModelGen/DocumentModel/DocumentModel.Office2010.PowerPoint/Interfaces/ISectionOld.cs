namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SectionOld Class.
/// </summary>
public interface ISectionOld // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// slideIdLst, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Collections.Generic.List<System.UInt32>? SlideIdList { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
