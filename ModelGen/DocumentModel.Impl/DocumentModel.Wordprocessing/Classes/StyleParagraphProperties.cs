namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Paragraph Properties.
/// </summary>
public class StyleParagraphPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>, StyleParagraphProperties
{
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public FrameProperties? FrameProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public NumberingProperties? NumberingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public ParagraphBorders? ParagraphBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public Tabs? Tabs
  {
    get;
    set;
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public SpacingBetweenLines? SpacingBetweenLines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public Indentation? Indentation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public JustificationKind? Justification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Justification>();
        return (JustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Justification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.JustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Justification{ Val = (DocumentFormat.OpenXml.Wordprocessing.JustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
        return (TextDirectionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextDirection{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public VerticalTextAlignmentKind? TextAlignment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextAlignment>();
        return (VerticalTextAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextAlignment>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextAlignment{ Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public TextBoxTightWrapKind? TextBoxTightWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>();
        return (TextBoxTightWrapKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ParagraphPropertiesChange.
  /// </summary>
  public ParagraphPropertiesChange? ParagraphPropertiesChange
  {
    get;
    set;
  }
  
}
