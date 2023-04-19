namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Picture Class.
/// </summary>
public class Picture: ModelElement
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  ///   Publish to Server
  /// </summary>
  public bool? Published { get; set; }

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