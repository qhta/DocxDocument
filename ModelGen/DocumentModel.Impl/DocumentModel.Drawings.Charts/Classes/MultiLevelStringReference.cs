namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public partial class MultiLevelStringReferenceImpl: ModelElementImpl, MultiLevelStringReference
{
  public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MultiLevelStringReferenceImpl(): base() {}
  
  public MultiLevelStringReferenceImpl(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Formula != null)
        {
          if (value is not null)
            OpenXmlElement.Formula.Text = value;
          else
            OpenXmlElement.Formula = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Formula = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLevelStringCache? MultiLevelStringCache
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MultiLevelStringCacheImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MultiLevelStringCacheImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
