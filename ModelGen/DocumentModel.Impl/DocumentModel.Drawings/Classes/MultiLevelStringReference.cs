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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formula>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Formula{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
