namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public interface DataModelExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.DataModelExtensionBlock? DataModelExtensionBlock { get ; set; }
  
  public Boolean? RecolorImages { get ; set; }
  
}
