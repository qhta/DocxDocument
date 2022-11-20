namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Diagram.IRecolorImages))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IDataModelExtensionBlock))]
public class DataModelExtension: IDataModelExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
