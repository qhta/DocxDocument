namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public class DivBorderImpl: ModelElementImpl, DivBorder
{
  public DocumentFormat.OpenXml.Wordprocessing.DivBorder? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DivBorder?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DivBorderImpl(): base() {}
  
  public DivBorderImpl(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BorderTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BorderType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BorderTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
