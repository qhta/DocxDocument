namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the Section Class.
/// </summary>
public interface ISection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// SectionSlideIdList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SectionSlideIdList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
