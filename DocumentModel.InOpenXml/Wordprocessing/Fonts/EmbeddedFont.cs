namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies information about the embedded font storage in a WordprocessingML document.
/// This interface provides properties for the obfuscation key, subsetting status, and relationship ID, enabling secure and efficient embedding of font resources within the document.
/// </summary>
public partial interface EmbeddedFont: ICollectionItem
{
  
  /// <summary>
  /// Key used to obfuscate the embedded font. This key is required to retrieve the embedded font for viewing the document, using the algorithm described in the OpenXML specification.
  /// </summary>
  public string? FontKey { get; set; }
  
  /// <summary>
  /// Indicates whether the embedded font has been subsetted, meaning only the glyphs used in the document are stored to reduce file size.
  /// </summary>
  public bool? Subsetted { get; set; }
  
  /// <summary>
  /// Relationship ID to the specified font part. The relationship must match the required type for the parent element (e.g., embedBold, embedItalic, embedRegular).
  /// </summary>
  public string? Id { get; set; }
}