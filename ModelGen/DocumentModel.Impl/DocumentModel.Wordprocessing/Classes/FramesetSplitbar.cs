namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public class FramesetSplitbarImpl: ModelElementImpl, FramesetSplitbar
{
  public DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FramesetSplitbar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Width>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Width>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.String?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Width{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public Color? Color
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public OnOffOnlyKind? NoBorder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBorder>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoBorder>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NoBorder{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public OnOffOnlyKind? FlatBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FlatBorders>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FlatBorders>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FlatBorders{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
