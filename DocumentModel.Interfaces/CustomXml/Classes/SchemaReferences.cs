namespace DocumentModel.CustomXml;

/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public interface SchemaReferences: IModelElement
{
  public Collection<SchemaReference>? Items { get; set; }
}