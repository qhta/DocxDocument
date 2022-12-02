namespace DocumentModel.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public interface ISchemaReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.ISchemaReference>? SchemaReferences { get ; set; }
  
}
