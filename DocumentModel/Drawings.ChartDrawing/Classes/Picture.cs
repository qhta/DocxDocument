namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Defines the Picture Class.
/// </summary>
public class Picture
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }

  /// <summary>
  ///   Publish to Server
  /// </summary>
  public Boolean? Published { get; set; }

  /// <summary>
  ///   Non-Visual Picture Properties.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get; set; }

  /// <summary>
  ///   Picture Fill.
  /// </summary>
  public BlipFill? BlipFill { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Style.
  /// </summary>
  public Style? Style { get; set; }
}