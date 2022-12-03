namespace DocumentModel.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public interface SchemaReferences // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<SchemaReference>? SchemaReferences { get ; set; }
  
}
