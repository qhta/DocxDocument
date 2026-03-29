namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the gender to use in a salutation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationgender?view=office-pia` for Office interop details.
/// </remarks>
public enum SalutationGender
{
  /// <summary>
  /// Female gender.
  /// </summary>
  Female = 0,
  /// <summary>
  /// Male gender.
  /// </summary>
  Male = 1,
  /// <summary>
  /// Neutral gender.
  /// </summary>
  Neutral = 2,
  /// <summary>
  /// Unknown gender.
  /// </summary>
  Unknown = 3
}
