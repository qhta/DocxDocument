namespace DocumentModel.Drawing;

/// <summary>
/// Draw Arc To.
/// </summary>
public interface IArcTo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Arc Width Radius
  /// </summary>
  public System.String? WidthRadius { get ; set; }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  public System.String? HeightRadius { get ; set; }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  public System.String? StartAngle { get ; set; }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  public System.String? SwingAngle { get ; set; }
  
}
