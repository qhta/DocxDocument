namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public interface DataModelExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DataModelExtensionBlock? DataModelExtensionBlock { get ; set; }
  
  public Boolean? RecolorImages { get ; set; }
  
}
