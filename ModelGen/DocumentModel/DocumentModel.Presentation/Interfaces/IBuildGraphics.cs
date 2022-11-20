namespace DocumentModel.Presentation;

/// <summary>
/// Build Graphics.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildSubElement))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBuildAsOne))]
public interface IBuildGraphics // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public uint? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public bool? UiExpand { get ; set; }
  
  /// <summary>
  /// Build As One.
  /// </summary>
  public IBuildAsOne? BuildAsOne { get ; set; }
  
  /// <summary>
  /// Build Sub Elements.
  /// </summary>
  public IBuildSubElement? BuildSubElement { get ; set; }
  
}
