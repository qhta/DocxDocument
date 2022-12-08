namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public class FrameImpl: ModelElementImpl, Frame
{
  public DocumentFormat.OpenXml.Wordprocessing.Frame? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Frame?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Frame Size.
  /// </summary>
  public String? FrameSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  public String? FrameName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public RelationshipType? SourceFileReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public UInt32? MarginWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public UInt32? MarginHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public FrameScrollbarVisibilityKind? ScrollbarVisibility
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
        return (FrameScrollbarVisibilityKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility{ Val = (DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public OnOffOnlyKind? NoResizeAllowed
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public OnOffOnlyKind? LinkedToFile
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
        return (OnOffOnlyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.LinkedToFile{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
