namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public class GroupCharImpl: ModelElementImpl, GroupChar
{
  public DocumentFormat.OpenXml.Math.GroupChar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.GroupChar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupCharImpl(): base() {}
  
  public GroupCharImpl(DocumentFormat.OpenXml.Math.GroupChar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public DocumentModel.Math.GroupCharProperties? GroupCharProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
        if (item != null)
          return new DocumentModel.Math.GroupCharPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.GroupCharPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          return new DocumentModel.Math.BaseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BaseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
