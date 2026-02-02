namespace DocumentModel.Vml;
/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.ExtensionHandlingBehaviorValues))]
public enum ExtensionHandlingBehavior
{
  /// <summary>
  ///   Not renderable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ExtensionHandlingBehaviorValues.View))]
  View,
  /// <summary>
  ///   Editable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ExtensionHandlingBehaviorValues.Edit))]
  Edit,
  /// <summary>
  ///   Renderable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.ExtensionHandlingBehaviorValues.BackwardCompatible))]
  BackwardCompatible
}