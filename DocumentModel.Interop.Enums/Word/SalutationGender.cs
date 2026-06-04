namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationgender?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSalutationGender")]
public enum SalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  [WordInteropEnumValue("wdGenderFemale")]
  Female = 0,
  /// <summary>
  /// Male gender.
  /// </summary>
  [WordInteropEnumValue("wdGenderMale")]
  Male = 1,
  /// <summary>
  /// Neutral gender.
  /// </summary>
  [WordInteropEnumValue("wdGenderNeutral")]
  Neutral = 2,
  /// <summary>
  /// Unknown gender.
  /// </summary>
  [WordInteropEnumValue("wdGenderUnknown")]
  Unknown = 3
}
