namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationgender?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSalutationGender")]
public enum SalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  [InteropEnumValue("wdGenderFemale")]
  Female = 0,
  /// <summary>
  /// Male gender.
  /// </summary>
  [InteropEnumValue("wdGenderMale")]
  Male = 1,
  /// <summary>
  /// Neutral gender.
  /// </summary>
  [InteropEnumValue("wdGenderNeutral")]
  Neutral = 2,
  /// <summary>
  /// Unknown gender.
  /// </summary>
  [InteropEnumValue("wdGenderUnknown")]
  Unknown = 3
}
