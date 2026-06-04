namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocPartValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues))]
public enum DocPartType
{
  /// <summary>
  ///   No Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.None))]
  None,
  /// <summary>
  ///   Normal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.Normal))]
  Normal,
  /// <summary>
  ///   Automatically Replace Name With Content.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.AutoExp))]
  AutoExp,
  /// <summary>
  ///   AutoText User Interface Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.Toolbar))]
  Toolbar,
  /// <summary>
  ///   AutoCorrect Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.Speller))]
  Speller,
  /// <summary>
  ///   Form Field Help Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.FormField))]
  FormField,
  /// <summary>
  ///   Structured Document Tag Placeholder Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DocPartValues.SdtPlaceholder))]
  SdtPlaceholder
}