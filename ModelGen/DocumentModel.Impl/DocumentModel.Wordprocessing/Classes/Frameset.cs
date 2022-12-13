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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.Frame? Frame
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
