using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension class.
/// </summary>
public class DataModelExtension : Extension
{
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  public bool? RecolorImages { get; set; }
}