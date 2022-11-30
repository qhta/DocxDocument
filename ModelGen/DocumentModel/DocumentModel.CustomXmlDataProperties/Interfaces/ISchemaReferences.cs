namespace DocumentModel.CustomXmlDataProperties;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public interface ISchemaReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.CustomXmlDataProperties.ISchemaReference>? SchemaReferences { get ; set; }
  
}
