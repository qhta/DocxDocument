using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension Class.
/// </summary>
public class DataModelExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  public bool? RecolorImages { get; set; }
}