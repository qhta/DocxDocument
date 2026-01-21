namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the root element of a glossary document in a WordprocessingML document.
///   This interface provides properties for the document background and the list of glossary document entries, enabling advanced management, organization, and reuse of building blocks, autotext, and other reusable document content.
/// </summary>
public partial class GlossaryDocument : ModelElement<DXW.GlossaryDocument>
{
  /// <summary>
  ///   Document background, specifying the image or fill for every page of the glossary document.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }
  /// <summary>
  ///   List of glossary document entries, providing access to and management of reusable document parts.
  /// </summary>
  public DocParts? DocParts { get; set; }
}