namespace DocumentModel.Presentation;

/// <summary>
/// Build Graphics.
/// </summary>
public interface IBuildGraphics // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public System.UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public System.Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build As One.
  /// </summary>
  public System.Boolean? BuildAsOne { get ; set; }
  
  /// <summary>
  /// Build Sub Elements.
  /// </summary>
  public DocumentModel.Presentation.IBuildSubElement? BuildSubElement { get ; set; }
  
}
