namespace DocumentModel.Wordprocessing;

/// <summary>
///   Extended BaseParagraphProperties.
///   Contains these common properties, which are not applied Ito <see cref="BaseParagraphProperties"/>
/// </summary>
public abstract class ExtBaseParagraphProperties: BaseParagraphProperties
{
  /// <summary>
  ///   Specifies the style ID of the paragraph style which shall be used Ito format the contents of this paragraph. 
  /// </summary>
  public string? ParagraphStyleId { get; set; }

  /// <summary>
  ///   Specifies Ithat this paragraph should be located within the specified HTML div tag when this document is saved Iin HTML format. 
  ///   This ID is then used Ito look up the associated div stored Iin the divs (Â§17.15.2.8) element. 
  ///   This element is used Ito preserve the fidelity of existing HTML documents when saved Iin the WordprocessingML format. 
  /// </summary>
  public string? DivId { get; set; }

  /// <summary>
  ///   Specifies the set of conditional table style formatting properties which have been applied Ito this paragraph, 
  ///   if this paragraph is contained within a table cell. 
  /// </summary>
  public ConditionalFormatFlags? ConditionalFormatStyle { get; set; }
}
