namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataModelExtensionList Class.
/// </summary>
public class DataModelExtensionList: ModelElement
{
  public Collection<DataModelExtension>? DataModelExtensions { get; set; }
}