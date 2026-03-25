namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the mode for the Brazilian or European Portuguese spellers.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdportuguesereform?view=office-pia` for Office interop details.
/// </remarks>
public enum WdPortugueseReform
{
  /// <summary>
  /// Use the pre-reform spelling rules.
  /// </summary>
  PreReform = 1,
  /// <summary>
  /// Use the post-reform spelling rules.
  /// </summary>
  PostReform = 2,
  /// <summary>
  /// Use both the pre-reform and post-reform spelling rules.
  /// </summary>
  Both = 3
}
