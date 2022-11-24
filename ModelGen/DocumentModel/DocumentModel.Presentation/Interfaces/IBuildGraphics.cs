namespace DocumentModel.Presentation;

/// <summary>
/// Build Graphics.
/// </summary>
public interface IBuildGraphics // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build As One.
  /// </summary>
  public IBuildAsOne? BuildAsOne { get ; set; }
  
  /// <summary>
  /// Build Sub Elements.
  /// </summary>
  public IBuildSubElement? BuildSubElement { get ; set; }
  
}
