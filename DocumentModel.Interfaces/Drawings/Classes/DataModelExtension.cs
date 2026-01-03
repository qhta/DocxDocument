using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension interface.
/// </summary>
public interface DataModelExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  public bool? RecolorImages { get; set; }
}