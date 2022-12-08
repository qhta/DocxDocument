namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public class MultiLevelStringCacheImpl: ModelElementImpl, MultiLevelStringCache
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PointCount.
  /// </summary>
  public UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<Level>? Levels
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
