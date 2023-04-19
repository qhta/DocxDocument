namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies information about the embedded font storage. 
/// </summary>
public partial class EmbeddedFont : ModelElement
{
  /// <summary>
  ///   Specifies the key which was used to obfuscate this embedded font. 
  ///   This key can be used to retrieve the embedded font for the purposes of viewing this WordprocessingML document only, 
  ///   using the algorithm described in §17.8.1.
  /// </summary>
  public string? FontKey { get; set; }

  /// <summary>
  ///   Specifies that the embedded font targeted by the id attribute has been subsetted. 
  ///   Subsetting is a mechanism by which only the glyphs used in the contents of this WordprocessingML document are stored in an embedded font,
  ///   in order to prevent the file from becoming unnecessarily large from the use of a small number of glyphs from a large embedded font.
  /// </summary>
  public bool? Subsetted { get; set; }

  /// <summary>
  ///   Specifies the relationship ID to a specified part.  
  ///   The specified relationship shall match the relationship type required by the parent element: 
  ///   http://purl.oclc.org/ooxml/officeDocument/relationships/font for the embedBold, embedBoldItalic, embedItalic, or embedRegular elements 
  /// </summary>
  public string? Id { get; set; }
}