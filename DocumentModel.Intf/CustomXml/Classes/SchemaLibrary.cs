namespace DocumentModel.CustomXml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Embedded Custom XML Schema Supplementary Data.
/// </summary>
public class SchemaLibrary: ModelElement
{
  public Collection<Schema>? Schemas { get; set; }
}