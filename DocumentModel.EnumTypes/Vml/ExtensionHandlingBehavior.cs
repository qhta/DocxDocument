namespace DocumentModel.Vml;
/// <summary>
///   VML Extension Handling Behaviors
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues))]
public enum ExtensionHandlingBehavior
{
  /// <summary>
  ///   Not renderable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.View))]
  View,
  /// <summary>
  ///   Editable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.Edit))]
  Edit,
  /// <summary>
  ///   Renderable.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.BackwardCompatible))]
  BackwardCompatible
}