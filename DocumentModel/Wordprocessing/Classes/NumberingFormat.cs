namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Footnote Numbering Format.
/// </summary>
public class NumberingFormat: ModelElement
{
  /// <summary>
  ///   Numbering Format Type
  /// </summary>
  public NumberFormatKind? Val { get; set; }

  /// <summary>
  ///   format, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Format { get; set; }
}