namespace DocumentModel.Presentation;

/// <summary>
/// Build Graphics.
/// </summary>
public interface BuildGraphics // : DocumentModel.BaseTypes.ModelElement
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
  public Boolean? BuildAsOne { get ; set; }
  
  /// <summary>
  /// Build Sub Elements.
  /// </summary>
  public BuildSubElement? BuildSubElement { get ; set; }
  
}
