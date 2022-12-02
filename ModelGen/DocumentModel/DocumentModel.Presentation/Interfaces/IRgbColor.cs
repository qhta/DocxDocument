namespace DocumentModel.Presentation;

/// <summary>
/// RGB.
/// </summary>
public interface IRgbColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Red
  /// </summary>
  public Int32? Red { get ; set; }
  
  /// <summary>
  /// Green
  /// </summary>
  public Int32? Green { get ; set; }
  
  /// <summary>
  /// Blue
  /// </summary>
  public Int32? Blue { get ; set; }
  
}
