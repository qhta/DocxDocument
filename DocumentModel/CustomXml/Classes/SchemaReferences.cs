namespace DocumentModel.CustomXml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public class SchemaReferences: ModelElement
{
  public Collection<SchemaReference>? Items { get; set; }
}