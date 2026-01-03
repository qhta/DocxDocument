namespace DocumentModel.CustomXml;

/// <summary>
///   Represents a reference to an associated XML schema by its target namespace.
/// </summary>
/// <remarks>
///   This interface defines a lightweight schema reference
///   that identifies an XML schema through its target namespace URI. Unlike the <see cref="Schema"/>
///   interface which includes manifest and physical file locations, SchemaReference provides a minimal
///   representation focused solely on namespace identification. This is typically used within a
///   <see cref="SchemaReferences"/> collection to associate one or more schemas with a <see cref="DataStoreItem"/>,
///   enabling validation and structure definition for custom XML data. The referenced schema may be
///   resolved from the document's <see cref="SchemaLibrary"/> or from external schema sources.
/// </remarks>
public interface SchemaReference : IModelElement
{
  /// <summary>
  ///   Gets or sets the target namespace URI of the associated XML schema.
  /// </summary>
  /// <remarks>
  ///   The target namespace uniquely identifies the XML schema being referenced. This URI should match
  ///   the target namespace defined in the actual schema (XSD) file. The namespace is used to locate
  ///   the corresponding schema definition, either from the document's embedded <see cref="SchemaLibrary"/>
  ///   or from external schema sources, enabling validation of custom XML data elements that belong
  ///   to this namespace.
  /// </remarks>
  public string? Uri { get; set; }
}