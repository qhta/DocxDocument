namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies spelling rules for the Arabic spelling checker.
/// </summary>
public enum WdAraSpeller
{
  /// <summary>
  /// The spelling checker ignores spelling rules regarding either Arabic words ending with the letter yaa or Arabic
  /// words beginning with an alef hamza. wdInitialAlef1 The spelling checker uses spelling rules regarding Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  wdNone = unchecked((int)0),
  /// <summary>
  /// Specifies spelling rules for the Arabic spelling checker.
  /// </summary>
  wdInitialAlef = unchecked((int)1),
  /// <summary>
  /// The spelling checker uses spelling rules regarding Arabic words ending with the letter yaa.
  /// </summary>
  wdFinalYaa = unchecked((int)2),
  /// <summary>
  /// The spelling checker uses spelling rules regarding both Arabic words ending with the letter yaa and Arabic
  /// words beginning with an alef hamza.
  /// </summary>
  wdBoth = unchecked((int)3)
}
