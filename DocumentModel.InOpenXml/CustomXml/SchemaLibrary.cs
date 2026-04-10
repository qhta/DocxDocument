namespace DocumentModel.CustomXml;
/// <summary>
///   Represents a collection of embedded XML schema references that provide supplementary validation data for custom XML.
/// </summary>
/// <remarks>
///   This class extends <see cref = "ElementCollection{ItemType}"/> of <see cref = "Schema"/> and defines a library
///   of XML schema references stored within the document package. The schema library serves as a repository
///   of supplementary schema data that complements the schema references associated with individual custom XML
///   data stores. Schemas in the library can be referenced by multiple <see cref = "DataStoreItem"/> instances,
///   promoting schema reuse and reducing document size. The library typically contains XSD files embedded
///   within the document package, making documents self-contained and enabling offline validation of custom
///   XML data without requiring external schema resolution.
/// </remarks>
[OpenXmlType(typeof(Schema))]
[XmlRoot("SchemaLibrary", Namespace = "DocumentModel.CustomXml")]
public class SchemaLibrary : ModelElementCollection<Schema, DXCXSR.SchemaLibrary, DXCXSR.Schema>
{
}