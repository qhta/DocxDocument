namespace DocumentModel;
/// <summary>
/// Represents all custom document properties defined in the document.
/// </summary>
public partial class CustomDocumentProperties
{
  /// <summary>
  /// Provides access to the core properties of the document.
  /// </summary>
  public CustomProperties CustomProperties { get; private set; }
  
  /// <summary>
  /// Initializing constructor. Initializes the properties based on the provided document.
  /// </summary>
  /// <param name="document">The document from which to initialize the properties.</param>
  public CustomDocumentProperties(DMW.Document document)
  {
    CustomProperties = document.CustomProperties;
  }
}