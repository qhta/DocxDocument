namespace DocumentModel.Vml;

/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
public enum ExtensionHandlingBehaviorKind
{
  /// <summary>
  ///   Not renderable.
  /// </summary>
  View,

  /// <summary>
  ///   Editable.
  /// </summary>
  Edit,

  /// <summary>
  ///   Renderable.
  /// </summary>
  BackwardCompatible
}