namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface Picture
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawings.Charts.BlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawings.Charts.Style? Style { get ; set; }
  
}
