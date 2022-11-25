namespace DocumentModel.Vml.Office;

/// <summary>
/// Skew Transform.
/// </summary>
public interface ISkew // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Skew ID
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Skew Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Skew Offset
  /// </summary>
  public System.String? Offset { get ; set; }
  
  /// <summary>
  /// Skew Origin
  /// </summary>
  public System.String? Origin { get ; set; }
  
  /// <summary>
  /// Skew Perspective Matrix
  /// </summary>
  public System.String? Matrix { get ; set; }
  
}
