namespace DocumentModel.Drawings;

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
  public NonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public BlipFill1? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties7? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public Style3? Style { get ; set; }
  
}
