namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface Picture
{
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public BlipFill2? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties7? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public Style4? Style { get ; set; }
  
}
