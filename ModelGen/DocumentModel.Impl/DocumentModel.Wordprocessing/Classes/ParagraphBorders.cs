namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphBorders Class.
/// </summary>
public partial class ParagraphBordersImpl: ModelElementImpl, ParagraphBorders
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ParagraphBordersImpl(): base() {}
  
  public ParagraphBordersImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Paragraph Border Above Identical Paragraphs.
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
  /// Left Paragraph Border.
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
  /// Paragraph Border Between Identical Paragraphs.
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
  /// Right Paragraph Border.
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
  
  /// <summary>
  /// Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BetweenBorder
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
  /// Paragraph Border Between Facing Pages.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BarBorder
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
