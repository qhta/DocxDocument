namespace DocumentModel.CustomXml;
/// <summary>
///   Represents a reference to an XML schema that defines the structure and validation rules for custom XML data.
/// </summary>
/// <remarks>
///   This class <see cref = "CollectionItem"/> and defines a schema
///   reference used to validate and describe the structure of custom XML data stored within Office documents.
///   Each schema reference includes the schema's namespace UriString, optional manifest location for schema discovery,
///   and the physical location of the schema file. Multiple schemas can be associated with a single custom XML
///   data store through a <see cref = "SchemaReferences"/> collection, enabling validation of complex XML structures
///   that span multiple namespaces. Schema references support both local and remote schema locations, allowing
///   documents to reference standard industry schemas or custom validation rules.
/// </remarks>
[OpenXmlTypeAttribute(typeof(DXCXSR.Schema))]
[DataContract]
[XmlRoot("Schema", Namespace = "DocumentModel.CustomXml")]
public partial class Schema : ModelElement<DXCXSR.Schema>
{
  /// <summary>
  ///  Namespace UriString that uniquely identifies this XML schema.
  /// </summary>
  /// <remarks>
  ///   The namespace UriString identifies the schema and matches the target namespace defined in the schema file.
  ///   This is used to associate XML elements in the custom XML data with their corresponding schema definitions.
  /// </remarks>
  [XmlAttribute]
  [OpenXmlProperty(nameof(DXCXSR.Schema.Uri))]
  public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }
  private string? _Uri;

  /// <summary>
  ///   Location of the resource manifest file for this schema.
  /// </summary>
  /// <remarks>
  ///   The manifest location can be used for schema discovery and resolution, particularly in scenarios
  ///   where multiple related schemas need to be loaded or when schema catalogs are employed.
  /// </remarks>
  [XmlAttribute]
  [OpenXmlProperty(nameof(DXCXSR.Schema.ManifestLocation))]
  public string? ManifestLocation { get => _ManifestLocation; set => UpdateField(ref _ManifestLocation, value, nameof(ManifestLocation)); }
  private string? _ManifestLocation;

  /// <summary>
  ///   Physical location of the XML schema file.
  /// </summary>
  /// <remarks>
  ///   The schema location points to the actual XSD (XML Schema Definition) file that contains
  ///   the validation rules and structure definitions. This can be a local file path, a relative path
  ///   within the document package, or a URL to a remote schema location.
  /// </remarks>
  [XmlAttribute]
  [OpenXmlProperty(nameof(DXCXSR.Schema.SchemaLocation))]
  public string? SchemaLocation { get => _SchemaLocation; set => UpdateField(ref _SchemaLocation, value, nameof(SchemaLocation)); }
  private string? _SchemaLocation;
}