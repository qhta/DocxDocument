namespace DocumentModel.CustomXmlSchemaReferences;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.CustomXmlSchemaReferences.ISchema))]
public class SchemaLibrary: ISchemaLibrary
{
}
