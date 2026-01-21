namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents properties for importing external content into a WordprocessingML document.
/// This class provides a property to control whether style definitions in the imported content are overridden by identical styles in the host document, enabling advanced management of style conflicts during content import operations.
/// </summary>
public partial class AltChunkProperties
{
  /// <summary>
  /// Indicates if style definitions present in the imported content should be overridden by identical styles in the host document. If true, styles in the imported content are maintained by redefining the style name and/or ID as needed. If false, styles from the main document replace those in the imported content.
  /// </summary>
  public bool? MatchSource { get; set; }
}