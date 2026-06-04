namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether CTRL+BREAK can or cannot interrupt a macro
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenablecancelkey?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdEnableCancelKey")]
public enum EnableCancelKey
{
  /// <summary>
  /// Prevents CTRL+BREAK from interrupting a macro.
  /// </summary>
  [InteropEnumValue("wdCancelDisabled")]
  Disabled = 0,
  /// <summary>
  /// Allows a macro to be interrupted by CTRL+BREAK.
  /// </summary>
  [InteropEnumValue("wdCancelInterrupt")]
  Interrupt = 1
}
