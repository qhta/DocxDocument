namespace DocumentModel.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public interface ISchemaReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISchemaReference>? SchemaReferences { get ; set; }
  
}
