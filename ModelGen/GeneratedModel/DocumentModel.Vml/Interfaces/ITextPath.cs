namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public interface ITextPath // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public string? Style { get ; set; }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  public ITrueFalseValue? FitShape { get ; set; }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  public ITrueFalseValue? FitPath { get ; set; }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  public ITrueFalseValue? Trim { get ; set; }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  public ITrueFalseValue? XScale { get ; set; }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  public string? String { get ; set; }
  
}
