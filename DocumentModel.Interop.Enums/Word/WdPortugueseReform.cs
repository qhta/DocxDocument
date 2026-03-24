namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the mode for the Brazilian or European Portuguese spellers.
/// </summary>
public enum WdPortugueseReform
{
  /// <summary>
  /// Use the pre-reform spelling rules.
  /// </summary>
  PreReform = unchecked((int)1),
  /// <summary>
  /// Use the post-reform spelling rules.
  /// </summary>
  PostReform = unchecked((int)2),
  /// <summary>
  /// Use both the pre-reform and post-reform spelling rules.
  /// </summary>
  Both = unchecked((int)3)
}
