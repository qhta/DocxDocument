namespace DocumentModel.Vml;

/// <summary>
/// VML Extension Handling Behaviors
/// </summary>
public enum ExtensionHandlingBehaviorKind
{
  /// <summary>
  /// Not renderable.
  /// </summary>
  [XmlEnum("view")]
  View,
  
  /// <summary>
  /// Editable.
  /// </summary>
  [XmlEnum("edit")]
  Edit,
  
  /// <summary>
  /// Renderable.
  /// </summary>
  [XmlEnum("backwardCompatible")]
  BackwardCompatible,
  
}
