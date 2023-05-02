namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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