namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsalutationtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  Informal = 0,
  /// <summary>
  /// Format salutation.
  /// </summary>
  Formal = 1,
  /// <summary>
  /// Business salutation
  /// </summary>
  Business = 2,
  /// <summary>
  /// Custom salutation.
  /// </summary>
  Other = 3
}
