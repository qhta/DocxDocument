namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DataModel Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IModelRelationships))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IModelTables))]
public class DataModel: IDataModel
{
  /// <summary>
  /// minVersionLoad, this property is only available in Office 2013 and later.
  /// </summary>
  public byte? MinVersionLoad
  {
    get;
    set;
  }
  
  /// <summary>
  /// ModelTables.
  /// </summary>
  public IModelTables? ModelTables
  {
    get;
    set;
  }
  
  /// <summary>
  /// ModelRelationships.
  /// </summary>
  public IModelRelationships? ModelRelationships
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
