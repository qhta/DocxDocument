namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtensionList Class.
/// </summary>
public interface DataModelExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DataModelExtension>? DataModelExtensions { get ; set; }
  
}
