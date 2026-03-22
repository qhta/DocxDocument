namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
public enum WdStyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  wdStyleTypeParagraph = unchecked((int)1),
  /// <summary>
  /// Body character style.
  /// </summary>
  wdStyleTypeCharacter = unchecked((int)2),
  /// <summary>
  /// Table style.
  /// </summary>
  wdStyleTypeTable = unchecked((int)3),
  /// <summary>
  /// List style.
  /// </summary>
  wdStyleTypeList = unchecked((int)4),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdStyleTypeParagraphOnly = unchecked((int)5),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdStyleTypeLinked = unchecked((int)6)
}
