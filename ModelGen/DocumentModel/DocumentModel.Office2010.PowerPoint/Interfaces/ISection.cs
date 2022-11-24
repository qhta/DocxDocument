namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the Section Class.
/// </summary>
public interface ISection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// SectionSlideIdList.
  /// </summary>
  public ISectionSlideIdList? SectionSlideIdList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
