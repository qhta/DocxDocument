namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the AnimationLevelString enumeration.
/// Used in types such as LayoutVariablePropertySetType, PresentationLayoutVariables, VariableList.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.AnimationLevelStringValues))]
public enum AnimationLevelString
{
  /// <summary>
  ///   Disable Level At Once.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   By Level Animation.
  /// </summary>
  [OpenXmlEnumValue("Level")]
  Level,
  /// <summary>
  ///   From Center Animation.
  /// </summary>
  [OpenXmlEnumValue("Center")]
  Center
}
