namespace DocumentModel.Vml.Office;

/// <summary>
/// Rule Set.
/// </summary>
public interface IRules // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
