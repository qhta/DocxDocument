namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public partial class FramesetImpl: ModelElementImpl, Frameset
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Frameset? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Frameset?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FramesetImpl(): base() {}
  
  public FramesetImpl(DocumentFormat.OpenXml.Wordprocessing.Frameset openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public String? FrameSize
  {
    get => (System.String?)OpenXmlElement?.FrameSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FrameSize != null)
        {
          if (value is not null)
            OpenXmlElement.FrameSize.Val = (System.String?)value;
          else
            OpenXmlElement.FrameSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FrameSize = new DocumentFormat.OpenXml.Wordprocessing.FrameSize{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.FramesetSplitbar? FramesetSplitbar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FramesetSplitbarImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FramesetSplitbarImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameLayoutKind? FrameLayout
  {
    get => (DocumentModel.Wordprocessing.FrameLayoutKind?)OpenXmlElement?.FrameLayout?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FrameLayout != null)
        {
          if (value is not null)
            OpenXmlElement.FrameLayout.Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value;
          else
            OpenXmlElement.FrameLayout = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FrameLayout = new DocumentFormat.OpenXml.Wordprocessing.FrameLayout{ Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value };
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Frameset? ChildFrameset
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FramesetImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FramesetImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.Frame? Frame
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FrameImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frame>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FrameImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
