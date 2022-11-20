namespace DocumentModel.Vml.Office;

/// <summary>
/// Skew Transform.
/// </summary>
public interface ISkew // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public string? Offset { get ; set; }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public string? Origin { get ; set; }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public string? Matrix { get ; set; }
  
}
