namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the Spanish speller modes.
/// </summary>
public enum WdSpanishSpeller
{
  /// <summary>
  /// The Spanish spelling checker recognizes only tuteo verb forms.
  /// </summary>
  TuteoOnly = unchecked((int)0),
  /// <summary>
  /// The Spanish spelling checker recognizes both tuteo and voseo verb forms.
  /// </summary>
  TuteoAndVoseo = unchecked((int)1),
  /// <summary>
  /// The Spanish spelling checker recognizes only voseo verb forms.
  /// </summary>
  VoseoOnly = unchecked((int)2)
}
