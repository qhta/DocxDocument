namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextBoxFormFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues))]
public enum TextBoxFormField
{
  /// <summary>
  ///   Text Box.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.Regular))]
  Regular,
  /// <summary>
  ///   Number.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.Number))]
  Number,
  /// <summary>
  ///   Date.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.Date))]
  Date,
  /// <summary>
  ///   Current Time Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.CurrentTime))]
  CurrentTime,
  /// <summary>
  ///   Current Date Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.CurrentDate))]
  CurrentDate,
  /// <summary>
  ///   Field Calculation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues.Calculated))]
  Calculated
}