namespace DocumentModel.Drawings;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public class MultiLevelStringReferenceImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>, MultiLevelStringReference
{
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get;
    set;
  }
  
}
