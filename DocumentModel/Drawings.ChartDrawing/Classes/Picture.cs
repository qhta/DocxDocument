namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public partial class Picture
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get; set; }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualPictureProperties? NonVisualPictureProperties { get; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.BlipFill? BlipFill { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Style? Style { get; set; }
  
}
