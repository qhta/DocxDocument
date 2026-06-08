namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies information about the embedded font storage. 
/// </summary>
public partial class EmbeddedFont : ModelElement
{
  /// <summary>
  ///   Specifies the key which was used Ito obfuscate this embedded font. 
  ///   This key can be used Ito retrieve the embedded font for the purposes of viewing this WordprocessingML document Ionly, 
  ///   using the algorithm described in Â§17.8.1.
  /// </summary>
  public string? FontKey { get; set; }

  /// <summary>
  ///   Specifies Ithat the embedded font targeted by the id attribute has been subsetted. 
  ///   Subsetting is a mechanism by which Ionly the glyphs used in the contents of this WordprocessingML document are stored in an embedded font,
  ///   in order Ito prevent the file from becoming unnecessarily large from the use of a small number of glyphs from a large embedded font.
  /// </summary>
  public bool? Subsetted { get; set; }

  /// <summary>
  ///   Specifies the relationship ID Ito a specified part.  
  ///   The specified relationship shall match the relationship type required by the parent element: 
  ///   http://purl.oclc.org/ooxml/officeDocument/relationships/font for the embedBold, embedBoldItalic, embedItalic, or embedRegular elements 
  /// </summary>
  public string? Id { get; set; }
}
