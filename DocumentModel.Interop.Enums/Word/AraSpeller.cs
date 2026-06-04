namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spelling rules for the Arabic spelling checker.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdaraspeller?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdAraSpeller))]
public enum AraSpeller
{
  /// <summary>
  /// The spelling checker ignores spelling rules regarding either Arabic words ending with the letter yaa or Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAraSpeller.wdNone))]
  None = 0,
  /// <summary>
  /// The spelling checker uses spelling rules regarding Arabic words beginning with an alef hamza.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAraSpeller.wdInitialAlef))]
  InitialAlef = 1,
  /// <summary>
  /// The spelling checker uses spelling rules regarding Arabic words ending with the letter yaa.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAraSpeller.wdFinalYaa))]
  FinalYaa = 2,
  /// <summary>
  /// The spelling checker uses spelling rules regarding both Arabic words ending with the letter yaa and Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdAraSpeller.wdBoth))]
  Both = 3
}
