namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the AnimateOneByOne enumeration.
/// Used in types such as LayoutVariablePropertySetType, PresentationLayoutVariables, VariableList.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues))]
public enum AnimateOneByOne
{
  /// <summary>
  ///   Disable One-by-One.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   One By One.
  /// </summary>
  [OpenXmlEnumValue("One")]
  One,
  /// <summary>
  ///   By Branch One By One.
  /// </summary>
  [OpenXmlEnumValue("Branch")]
  Branch
}

