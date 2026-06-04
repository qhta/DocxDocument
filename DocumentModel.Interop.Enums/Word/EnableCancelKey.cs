namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether CTRL+BREAK can or cannot interrupt a macro
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenablecancelkey?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEnableCancelKey))]
public enum EnableCancelKey
{
  /// <summary>
  /// Prevents CTRL+BREAK from interrupting a macro.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnableCancelKey.wdCancelDisabled))]
  Disabled = 0,
  /// <summary>
  /// Allows a macro to be interrupted by CTRL+BREAK.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEnableCancelKey.wdCancelInterrupt))]
  Interrupt = 1
}
