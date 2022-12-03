namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
public interface NonVisualGraphicFrameProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
  /// <summary>
  /// Application Non-Visual Drawing Properties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
}
