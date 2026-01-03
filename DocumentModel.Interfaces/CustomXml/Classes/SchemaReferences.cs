namespace DocumentModel.CustomXml;

/// <summary>
///   Represents a collection of XML schema references associated with a custom XML data store.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a collection of <see cref="SchemaReference"/>
///   objects that identify the XML schemas used to validate and describe the structure of custom XML data.
///   Each <see cref="DataStoreItem"/> can have an associated SchemaReferences collection that specifies one or
///   more schemas governing the XML data's structure and validation rules. Multiple schema references enable
///   support for complex XML documents that span multiple namespaces, where different portions of the XML data
///   conform to different schema definitions. The referenced schemas may be resolved from the document's embedded
///   <see cref="SchemaLibrary"/> or from external schema sources, providing flexibility in schema management
///   and enabling both self-contained documents and documents that reference standard industry schemas.
/// </remarks>
public interface SchemaReferences : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of schema reference items.
  /// </summary>
  /// <remarks>
  ///   Each item in the collection references a schema by its target namespace URI. The schemas identified
  ///   by these references provide validation rules and structure definitions for the custom XML data stored
  ///   in the associated <see cref="DataStoreItem"/>.
  /// </remarks>
  public Collection<SchemaReference>? Items { get; set; }
}