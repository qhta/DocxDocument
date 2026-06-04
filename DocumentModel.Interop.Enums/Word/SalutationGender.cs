namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationgender?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSalutationGender))]
public enum SalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationGender.wdGenderFemale))]
  Female = 0,
  /// <summary>
  /// Male gender.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationGender.wdGenderMale))]
  Male = 1,
  /// <summary>
  /// Neutral gender.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationGender.wdGenderNeutral))]
  Neutral = 2,
  /// <summary>
  /// Unknown gender.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSalutationGender.wdGenderUnknown))]
  Unknown = 3
}
