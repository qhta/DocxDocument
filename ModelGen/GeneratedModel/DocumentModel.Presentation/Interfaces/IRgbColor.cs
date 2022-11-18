namespace DocumentModel.Presentation;

/// <summary>
/// RGB.
/// </summary>
public interface IRgbColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Red
  /// </summary>
  public int? Red { get ; set; }
  
  /// <summary>
  /// Green
  /// </summary>
  public int? Green { get ; set; }
  
  /// <summary>
  /// Blue
  /// </summary>
  public int? Blue { get ; set; }
  
}
