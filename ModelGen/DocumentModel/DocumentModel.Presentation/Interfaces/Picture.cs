namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface Picture // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Properties for a Picture.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public BlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
