namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DataModelExtensionList Class.
/// </summary>
public record DataModelExtensionList
{
  public Collection<DataModelExtension>? DataModelExtensions { get; set; }
}