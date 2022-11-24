namespace DocumentModel.Vml.Office;

/// <summary>
/// Skew Transform.
/// </summary>
public interface ISkew // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public String? Offset { get ; set; }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public String? Origin { get ; set; }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public String? Matrix { get ; set; }
  
}
