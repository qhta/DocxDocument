namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface ContentPart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BwMode { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public NonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// ExtensionListModify.
  /// </summary>
  public ExtensionListModify? ExtensionListModify { get ; set; }
  
}
