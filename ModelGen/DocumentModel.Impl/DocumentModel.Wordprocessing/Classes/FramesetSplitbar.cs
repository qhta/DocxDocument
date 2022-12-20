namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public partial class FramesetSplitbarImpl: ModelElementImpl, FramesetSplitbar
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FramesetSplitbarImpl(): base() {}
  
  public FramesetSplitbarImpl(DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  public String? Width
  {
    get => (System.String?)OpenXmlElement?.Width?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Width != null)
        {
          if (value is not null)
            OpenXmlElement.Width.Val = (System.String?)value;
          else
            OpenXmlElement.Width = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Width = new DocumentFormat.OpenXml.Wordprocessing.Width{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public DocumentModel.Wordprocessing.Color? Color
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoBorder
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.NoBorder?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NoBorder != null)
        {
          if (value is not null)
            OpenXmlElement.NoBorder.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.NoBorder = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NoBorder = new DocumentFormat.OpenXml.Wordprocessing.NoBorder{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? FlatBorders
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.FlatBorders?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FlatBorders != null)
        {
          if (value is not null)
            OpenXmlElement.FlatBorders.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.FlatBorders = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FlatBorders = new DocumentFormat.OpenXml.Wordprocessing.FlatBorders{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
}
