namespace DocumentModel.CustomXml;

/// <summary>
///   Represents a reference to an XML schema that defines the structure and validation rules for custom XML data.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and <see cref="ICollectionItem"/> and defines a schema
///   reference used to validate and describe the structure of custom XML data stored within Office documents.
///   Each schema reference includes the schema's namespace URI, optional manifest location for schema discovery,
///   and the physical location of the schema file. Multiple schemas can be associated with a single custom XML
///   data store through a <see cref="SchemaReferences"/> collection, enabling validation of complex XML structures
///   that span multiple namespaces. Schema references support both local and remote schema locations, allowing
///   documents to reference standard industry schemas or custom validation rules.
/// </remarks>
public interface Schema : IModelElement, ICollectionItem
{
  /// <summary>
  ///   Gets or sets the namespace URI that uniquely identifies this XML schema.
  /// </summary>
  /// <remarks>
  ///   The namespace URI identifies the schema and matches the target namespace defined in the schema file.
  ///   This is used to associate XML elements in the custom XML data with their corresponding schema definitions.
  /// </remarks>
  public Uri? Uri { get; set; }

  /// <summary>
  ///   Gets or sets the location of the resource manifest file for this schema.
  /// </summary>
  /// <remarks>
  ///   The manifest location can be used for schema discovery and resolution, particularly in scenarios
  ///   where multiple related schemas need to be loaded or when schema catalogs are employed.
  /// </remarks>
  public string? ManifestLocation { get; set; }

  /// <summary>
  ///   Gets or sets the physical location of the XML schema file.
  /// </summary>
  /// <remarks>
  ///   The schema location points to the actual XSD (XML Schema Definition) file that contains
  ///   the validation rules and structure definitions. This can be a local file path, a relative path
  ///   within the document package, or a URL to a remote schema location.
  /// </remarks>
  public string? SchemaLocation { get; set; }
}