namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface IContentPart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteModeValues? BwMode { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// ExtensionListModify.
  /// </summary>
  public IExtensionListModify? ExtensionListModify { get ; set; }
  
}
