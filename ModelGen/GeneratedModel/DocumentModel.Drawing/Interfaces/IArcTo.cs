namespace DocumentModel.Drawing;

/// <summary>
/// Draw Arc To.
/// </summary>
public interface IArcTo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Arc Width Radius
  /// </summary>
  public string? WidthRadius { get ; set; }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  public string? HeightRadius { get ; set; }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  public string? StartAngle { get ; set; }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  public string? SwingAngle { get ; set; }
  
}
