namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
public enum WdSalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  wdSalutationInformal = unchecked((int)0),
  /// <summary>
  /// Format salutation.
  /// </summary>
  wdSalutationFormal = unchecked((int)1),
  /// <summary>
  /// Business salutation
  /// </summary>
  wdSalutationBusiness = unchecked((int)2),
  /// <summary>
  /// Custom salutation.
  /// </summary>
  wdSalutationOther = unchecked((int)3)
}
