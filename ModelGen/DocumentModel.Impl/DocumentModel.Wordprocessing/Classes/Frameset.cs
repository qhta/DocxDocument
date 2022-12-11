namespace DocumentModel.Wordprocessing;

/// <summary>
/// Nested Frameset Definition.
/// </summary>
public class FramesetImpl: ModelElementImpl, Frameset
{
  public DocumentFormat.OpenXml.Wordprocessing.Frameset? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Frameset?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameSize>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.FrameSize{ Val = (System.String?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Frameset Layout.
  /// </summary>
  public FrameLayoutKind? FrameLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameLayout>();
        return (FrameLayoutKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameLayout>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.FrameLayout{ Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Frameset? ChildFrameset
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Frame? Frame
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
