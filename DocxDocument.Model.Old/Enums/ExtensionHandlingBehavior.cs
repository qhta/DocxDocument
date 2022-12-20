using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

/// <summary>
/// VML Extension Handling Behaviors
/// </summary>
public enum ExtensionHandlingBehavior{
  /// <summary>
  /// Not renderable.
  /// <para>When the item is serialized out as xml, its value is "view".</para>
  /// </summary>
  [EnumString("view")]
  View,
  /// <summary>
  /// Editable.
  /// <para>When the item is serialized out as xml, its value is "edit".</para>
  /// </summary>
  [EnumString("edit")]
  Edit,
  /// <summary>
  /// Renderable.
  /// <para>When the item is serialized out as xml, its value is "backwardCompatible".</para>
  /// </summary>
  [EnumString("backwardCompatible")]
  BackwardCompatible
}
