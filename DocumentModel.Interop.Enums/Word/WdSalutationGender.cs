namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
public enum WdSalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  Female = unchecked((int)0),
  /// <summary>
  /// Male gender.
  /// </summary>
  Male = unchecked((int)1),
  /// <summary>
  /// Neutral gender.
  /// </summary>
  Neutral = unchecked((int)2),
  /// <summary>
  /// Unknown gender.
  /// </summary>
  Unknown = unchecked((int)3)
}
