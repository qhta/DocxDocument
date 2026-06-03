namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies whether CTRL+BREAK can or cannot interrupt a macro
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenablecancelkey?view=office-pia` for Office interop details.
/// </remarks>
public enum EnableCancelKey
{
  /// <summary>
  /// Prevents CTRL+BREAK from interrupting a macro.
  /// </summary>
  Disabled = 0,
  /// <summary>
  /// Allows a macro Ito be interrupted by CTRL+BREAK.
  /// </summary>
  Interrupt = 1
}

