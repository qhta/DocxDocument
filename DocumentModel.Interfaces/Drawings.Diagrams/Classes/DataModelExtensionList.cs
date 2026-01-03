namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the DataModelExtensionList Class.
/// </summary>
public interface DataModelExtensionList: IModelElement
{
  public Collection<DataModelExtension>? DataModelExtensions { get; set; }
}