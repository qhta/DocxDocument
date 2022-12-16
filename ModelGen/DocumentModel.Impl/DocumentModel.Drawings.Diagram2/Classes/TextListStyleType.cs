namespace DocumentModel.Drawings.Diagram2;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public class TextListStyleTypeImpl: ModelElementImpl, TextListStyleType
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextListStyleTypeImpl(): base() {}
  
  public TextListStyleTypeImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public DocumentModel.Drawings.DefaultParagraphProperties? DefaultParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.DefaultParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.DefaultParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level1ParagraphProperties? Level1ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level1ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level1ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level2ParagraphProperties? Level2ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level2ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level2ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level3ParagraphProperties? Level3ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level3ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level3ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level4ParagraphProperties? Level4ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level4ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level4ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level5ParagraphProperties? Level5ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level5ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level5ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level6ParagraphProperties? Level6ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level6ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level6ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level7ParagraphProperties? Level7ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level7ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level7ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level8ParagraphProperties? Level8ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level8ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level8ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public DocumentModel.Drawings.Level9ParagraphProperties? Level9ParagraphProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Level9ParagraphPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Level9ParagraphPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
