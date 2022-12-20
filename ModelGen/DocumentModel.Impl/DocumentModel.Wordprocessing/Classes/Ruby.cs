namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public partial class RubyImpl: ModelElementImpl, Ruby
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Ruby? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Ruby?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RubyImpl(): base() {}
  
  public RubyImpl(DocumentFormat.OpenXml.Wordprocessing.Ruby openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyProperties? RubyProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RubyPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RubyPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyContent? RubyContent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RubyContentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyContent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RubyContentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyBase? RubyBase
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RubyBaseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyBase>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RubyBaseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
