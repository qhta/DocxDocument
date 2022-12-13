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
  
  public FrameImpl(): base() {}
  
  public FrameImpl(DocumentFormat.OpenXml.Wordprocessing.Frame openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Frame Size.
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
  /// Frame Name.
  /// </summary>
  public String? FrameName
  {
    get => (System.String?)OpenXmlElement?.FrameName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FrameName != null)
        {
          if (value is not null)
            OpenXmlElement.FrameName.Val = (System.String?)value;
          else
            OpenXmlElement.FrameName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FrameName = new DocumentFormat.OpenXml.Wordprocessing.FrameName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? SourceFileReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public UInt32? MarginWidth
  {
    get => (System.UInt32?)OpenXmlElement?.MarginWidth?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MarginWidth != null)
        {
          if (value is not null)
            OpenXmlElement.MarginWidth.Val = (System.UInt32?)value;
          else
            OpenXmlElement.MarginWidth = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MarginWidth = new DocumentFormat.OpenXml.Wordprocessing.MarginWidth{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public UInt32? MarginHeight
  {
    get => (System.UInt32?)OpenXmlElement?.MarginHeight?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MarginHeight != null)
        {
          if (value is not null)
            OpenXmlElement.MarginHeight.Val = (System.UInt32?)value;
          else
            OpenXmlElement.MarginHeight = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MarginHeight = new DocumentFormat.OpenXml.Wordprocessing.MarginHeight{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? ScrollbarVisibility
  {
    get => (DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind?)OpenXmlElement?.ScrollbarVisibility?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ScrollbarVisibility != null)
        {
          if (value is not null)
            OpenXmlElement.ScrollbarVisibility.Val = (DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues?)value;
          else
            OpenXmlElement.ScrollbarVisibility = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ScrollbarVisibility = new DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility{ Val = (DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoResizeAllowed
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.NoResizeAllowed?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NoResizeAllowed != null)
        {
          if (value is not null)
            OpenXmlElement.NoResizeAllowed.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.NoResizeAllowed = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NoResizeAllowed = new DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? LinkedToFile
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.LinkedToFile?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LinkedToFile != null)
        {
          if (value is not null)
            OpenXmlElement.LinkedToFile.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.LinkedToFile = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LinkedToFile = new DocumentFormat.OpenXml.Wordprocessing.LinkedToFile{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
}
