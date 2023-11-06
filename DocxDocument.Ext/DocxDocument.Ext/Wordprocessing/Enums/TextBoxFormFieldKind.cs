namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextBoxFormFieldValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum TextBoxFormFieldKind
{
  /// <summary>
  ///   Text Box.
  /// </summary>
  Regular,

  /// <summary>
  ///   Number.
  /// </summary>
  Number,

  /// <summary>
  ///   Date.
  /// </summary>
  Date,

  /// <summary>
  ///   Current Time Display.
  /// </summary>
  CurrentTime,

  /// <summary>
  ///   Current Date Display.
  /// </summary>
  CurrentDate,

  /// <summary>
  ///   Field Calculation.
  /// </summary>
  Calculated
}