namespace DocumentModel.Vml;

/// <summary>
///   Complex.
/// </summary>
public class Complex: ModelElement<DXVO.Complex>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
}