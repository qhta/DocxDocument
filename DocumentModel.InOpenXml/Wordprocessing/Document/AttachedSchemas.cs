using DocumentModel.CustomXml;
namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a collection of additional schemas attached to a WordprocessingML document.
  /// This interface provides access to and management of <see cref="Schema"/> objects, enabling advanced integration and validation of custom XML data using external or supplementary XML schemas.
  /// </summary>
  public class AttachedSchemas : ElementCollection<Schema>
  {
    
  }