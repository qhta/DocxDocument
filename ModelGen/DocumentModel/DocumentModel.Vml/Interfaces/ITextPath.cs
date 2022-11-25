namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextPath Class.
/// </summary>
public interface ITextPath // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Shape Fit Toggle
  /// </summary>
  public System.Boolean? FitShape { get ; set; }
  
  /// <summary>
  /// Path Fit Toggle
  /// </summary>
  public System.Boolean? FitPath { get ; set; }
  
  /// <summary>
  /// Text Path Trim Toggle
  /// </summary>
  public System.Boolean? Trim { get ; set; }
  
  /// <summary>
  /// Text X-Scaling
  /// </summary>
  public System.Boolean? XScale { get ; set; }
  
  /// <summary>
  /// Text Path Text
  /// </summary>
  public System.String? String { get ; set; }
  
}
