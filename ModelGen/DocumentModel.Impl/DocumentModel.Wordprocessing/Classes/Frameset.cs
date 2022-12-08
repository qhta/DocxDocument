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
  
  /// <summary>
  /// Nested Frameset Size.
  /// </summary>
  public String? FrameSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frameset Splitter Properties.
  /// </summary>
  public FramesetSplitbar? FramesetSplitbar
  {
    get;
    set;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameLayout>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.FrameLayout{ Val = (DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Collection<Frameset>? Framesets
  {
    get;
    set;
  }
  
  public Collection<Frame>? Frames
  {
    get;
    set;
  }
  
}
