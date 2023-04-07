namespace DocumentModel.Wordprocessing;

/// <summary>
///   Extended BaseParagraphProperties.
///   Contains these common properties, which are not applied to <see cref="BaseParagraphProperties"/>
/// </summary>
public abstract class ExtBaseParagraphProperties: BaseParagraphProperties
{
  /// <summary>
  ///   Specifies the style ID of the paragraph style which shall be used to format the contents of this paragraph. 
  /// </summary>
  public String? ParagraphStyleId { get; set; }

  /// <summary>
  ///   Specifies the HTML div information which is associated with the current table row. 
  ///   This information, stored in the Web Settings part, is used to associate one or more table rows with a particular HTML div element. 
  ///   This property is used when saving an HTML document into the WordprocessingML format 
  ///   in order to prevent a loss of all HTML div information, 
  ///   so that the document can later be saved back into HTML format and have the stored information replaced, 
  ///   since the HTML div can store formatting properties on arbitrary regions.
  /// </summary>
  public String? DivId { get; set; }

  /// <summary>
  ///   Specifies the set of conditional table style formatting properties which have been applied to this paragraph, 
  ///   if this paragraph is contained within a table cell. 
  /// </summary>
  public ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
}