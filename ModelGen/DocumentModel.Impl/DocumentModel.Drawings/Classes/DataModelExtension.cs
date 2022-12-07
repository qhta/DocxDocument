namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public class DataModelExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.DataModelExtension>, DataModelExtension
{
  public DataModelExtensionBlock? DataModelExtensionBlock
  {
    get;
    set;
  }
  
}
