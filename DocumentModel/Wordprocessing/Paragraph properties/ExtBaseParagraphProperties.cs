namespace DocumentModel.Wordprocessing;

/// <summary>
///   Extended BaseParagraphProperties.
///   Contains these common properties, which are not applied to <see cref="BaseParagraphProperties"/>
/// </summary>
public abstract class ExtBaseParagraphProperties: BaseParagraphProperties
{
  /// <summary>
  ///   ParagraphStyleId.
  /// </summary>
  public String? ParagraphStyleId { get; set; }

  /// <summary>
  ///   DivId.
  /// </summary>
  public String? DivId { get; set; }

  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
}