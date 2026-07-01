namespace DocumentModel.CustomXml;
/// <summary>
///   Represents a custom XML data item stored within a document with associated schema information.
/// </summary>
/// <remarks>
///   This class defines a container for custom XML data
///   that can be embedded within Office documents. Custom XML data stores allow documents to contain
///   structured data that can be mapped to document content controls or accessed programmatically.
///   Each data store item is uniquely identified and can reference one or more XML schemas that
///   define the structure and validation rules for the contained XML data. This functionality enables
///   data-driven documents, content control binding, and integration with external data sources.
/// </remarks>
[DataContract]
[XmlRoot("DataStoreItem", Namespace = "DocumentModel.CustomXml")]
public partial class DataStoreItem
{
 /// <summary>
 ///   Gets or sets the unique identifier for this custom XML data item.
 /// </summary>
 /// <remarks>
 ///   The identifier is typically a GUID in string format and is used to reference this specific
 ///   custom XML data store from other parts of the document, such as content controls that bind
 ///   to the XML data.
 /// </remarks>
 public string? ItemId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 ///   Gets or sets the collection of XML schema references associated with this custom XML data.
 /// </summary>
 /// <remarks>
 ///   The schema references define the XML schemas that describe the structure and validation
 ///   rules for the custom XML data. Multiple schemas can be referenced to support complex
 ///   XML data structures that span multiple namespaces.
 /// </remarks>
 public SchemaReferences? SchemaReferences { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}