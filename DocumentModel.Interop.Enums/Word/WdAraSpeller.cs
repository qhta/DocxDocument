namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spelling rules for the Arabic spelling checker.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdaraspeller?view=office-pia` for Office interop details.
/// </remarks>
public enum WdAraSpeller
{
  /// <summary>
  /// The spelling checker ignores spelling rules regarding either Arabic words ending with the letter yaa or Arabic
  /// words beginning with an alef hamza. wdInitialAlef1 The spelling checker uses spelling rules regarding Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies spelling rules for the Arabic spelling checker.
  /// </summary>
  InitialAlef = 1,
  /// <summary>
  /// The spelling checker uses spelling rules regarding Arabic words ending with the letter yaa.
  /// </summary>
  FinalYaa = 2,
  /// <summary>
  /// The spelling checker uses spelling rules regarding both Arabic words ending with the letter yaa and Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  Both = 3
}
