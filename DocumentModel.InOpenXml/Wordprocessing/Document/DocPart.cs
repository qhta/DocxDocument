namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a glossary document entry (DocPart) in a WordprocessingML document.
  /// This class extends <see cref="DMPack.OpenXmlPart"/> and provides properties for entry properties and content, enabling advanced management, organization, and reuse of document parts such as building blocks, autotext, and other glossary entries.
  /// </summary>
  public class DocPart : ModelElement<DXW.DocPart>
  {
    
    /// <summary>
    /// Properties of the glossary document entry, specifying metadata and configuration for the entry.
    /// </summary>
    public DocPartProperties? DocPartProperties { get; set; }
    
    /// <summary>
    /// Contents of the glossary document entry, containing the actual content or body of the entry.
    /// </summary>
    public DocPartBody? DocPartBody { get; set; }
  }