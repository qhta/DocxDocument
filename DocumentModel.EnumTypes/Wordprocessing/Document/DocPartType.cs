namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocPartValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocPartValues))]
public enum DocPartType
{
  /// <summary>
  ///   No Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.None))]
  None,
  /// <summary>
  ///   Normal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.Normal))]
  Normal,
  /// <summary>
  ///   Automatically Replace Name With Content.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.AutoExp))]
  AutoExp,
  /// <summary>
  ///   AutoText User Interface Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.Toolbar))]
  Toolbar,
  /// <summary>
  ///   AutoCorrect Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.Speller))]
  Speller,
  /// <summary>
  ///   Form IField Help Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.FormField))]
  FormField,
  /// <summary>
  ///   Structured Document Tag Placeholder Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartValues.SdtPlaceholder))]
  SdtPlaceholder
}