namespace DocumentModel.Wordprocessing;
/// <summary>
///   Numbering Format.
/// </summary>
public interface NumberingFormat
{
  /// <summary>
  ///   Standard Numbering Format Type
  /// </summary>
  public NumberFormatKind? Type { get; set; }
  /// <summary>
  ///   Specifies a custom number format using the syntax defined by the XSLT format attribute. This format shall be used for all numbering in the parent object. 
  ///   [Example: A value of &#x30A2; indicates that a consumer must use Katakana numbering. end example] 
  /// </summary>
  public string? Custom { get; set; }
}