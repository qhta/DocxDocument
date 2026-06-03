namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextBoxFormFieldValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TextBoxFormFieldValues))]
public enum TextBoxFormField
{
  /// <summary>
  ///   Text Box.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.Regular))]
  Regular,
  /// <summary>
  ///   Number.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.Number))]
  Number,
  /// <summary>
  ///   Date.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.Date))]
  Date,
  /// <summary>
  ///   Current Time Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.CurrentTime))]
  CurrentTime,
  /// <summary>
  ///   Current Date Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.CurrentDate))]
  CurrentDate,
  /// <summary>
  ///   Field Calculation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxFormFieldValues.Calculated))]
  Calculated
}