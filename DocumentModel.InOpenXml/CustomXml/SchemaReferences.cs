namespace DocumentModel.CustomXml;
/// <summary>
///   Represents a collection of XML schema references associated with a custom XML data store.
/// </summary>
/// <remarks>
///   This class defines a collection of <see cref = "SchemaReference"/>
///   objects that identify the XML schemas used to validate and describe the structure of custom XML data.
///   Each <see cref = "DataStoreItem"/> can have an associated SchemaReferences collection that specifies one or
///   more schemas governing the XML data's structure and validation rules. Multiple schema references enable
///   support for complex XML documents that span multiple namespaces, where different portions of the XML data
///   conform to different schema definitions. The referenced schemas may be resolved from the document's embedded
///   <see cref = "SchemaLibrary"/> or from external schema sources, providing flexibility in schema management
///   and enabling both self-contained documents and documents that reference standard industry schemas.
/// </remarks>
[OpenXmlType(typeof(SchemaReference))]
[XmlRoot("SchemaReferences", Namespace = "DocumentModel.CustomXml")]
public class SchemaReferences : ElementCollection<SchemaReference>
{
}