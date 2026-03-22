namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
public enum WdSalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  wdGenderFemale = unchecked((int)0),
  /// <summary>
  /// Male gender.
  /// </summary>
  wdGenderMale = unchecked((int)1),
  /// <summary>
  /// Neutral gender.
  /// </summary>
  wdGenderNeutral = unchecked((int)2),
  /// <summary>
  /// Unknown gender.
  /// </summary>
  wdGenderUnknown = unchecked((int)3)
}
