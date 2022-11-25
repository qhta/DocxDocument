namespace DocumentModel.Presentation;

/// <summary>
/// RGB.
/// </summary>
public interface IRgbColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Red
  /// </summary>
  public System.Int32? Red { get ; set; }
  
  /// <summary>
  /// Green
  /// </summary>
  public System.Int32? Green { get ; set; }
  
  /// <summary>
  /// Blue
  /// </summary>
  public System.Int32? Blue { get ; set; }
  
}
