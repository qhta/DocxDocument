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
  public String? Uri { get; set; }

  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }

  public Boolean? RecolorImages { get; set; }
}