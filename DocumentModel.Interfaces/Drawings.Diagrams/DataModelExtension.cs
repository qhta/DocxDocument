using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension interface.
/// </summary>
public interface DataModelExtension: Extension
{
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  public bool? RecolorImages { get; set; }
}