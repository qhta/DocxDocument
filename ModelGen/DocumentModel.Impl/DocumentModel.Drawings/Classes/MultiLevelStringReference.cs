namespace DocumentModel.Drawings;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public class MultiLevelStringReferenceImpl: ModelElementImpl, MultiLevelStringReference
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get;
    set;
  }
  
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
