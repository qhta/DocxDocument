namespace DocumentModel.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public interface SignatureLine
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
