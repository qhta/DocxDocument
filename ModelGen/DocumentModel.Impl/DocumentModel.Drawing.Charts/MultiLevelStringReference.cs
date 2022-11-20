namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMultiLevelStringCache))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMultiLvlStrRefExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormula))]
public class MultiLevelStringReference: IMultiLevelStringReference
{
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Drawing.Charts.IFormula? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public IMultiLevelStringCache? MultiLevelStringCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get;
    set;
  }
  
}
