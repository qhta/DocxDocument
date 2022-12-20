namespace DocumentModel.Wordprocessing;

/// <summary>
/// Paragraph Properties.
/// </summary>
public partial class ParagraphPropertiesBaseStyleImpl: ModelElementImpl, ParagraphPropertiesBaseStyle
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesBaseStyleImpl(): base() {}
  
  public ParagraphPropertiesBaseStyleImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  public Boolean? KeepNext
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepNext>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepNext>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.KeepNext();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  public Boolean? KeepLines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepLines>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.KeepLines>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.KeepLines();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  public Boolean? PageBreakBefore
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.PageBreakBefore();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FrameProperties? FrameProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FramePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FrameProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FramePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  public Boolean? WidowControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidowControl>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidowControl>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.WidowControl();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingProperties? NumberingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NumberingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NumberingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  public Boolean? SuppressLineNumbers
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressLineNumbers();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphBorders? ParagraphBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ParagraphBordersImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphBorders>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ParagraphBordersImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ShadingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ShadingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public DocumentModel.Wordprocessing.Tabs? Tabs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TabsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tabs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TabsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  public Boolean? SuppressAutoHyphens
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressAutoHyphens();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  public Boolean? Kinsoku
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kinsoku>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Kinsoku>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Kinsoku();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  public Boolean? WordWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordWrap>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WordWrap>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.WordWrap();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  public Boolean? OverflowPunctuation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.OverflowPunctuation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  public Boolean? TopLinePunctuation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.TopLinePunctuation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  public Boolean? AutoSpaceDE
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDE();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  public Boolean? AutoSpaceDN
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AutoSpaceDN();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public Boolean? BiDi
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BiDi>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.BiDi();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  public Boolean? AdjustRightIndent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.AdjustRightIndent();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SnapToGrid>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SnapToGrid();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  public DocumentModel.Wordprocessing.SpacingBetweenLines? SpacingBetweenLines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SpacingBetweenLinesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SpacingBetweenLines>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SpacingBetweenLinesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  public DocumentModel.Wordprocessing.Indentation? Indentation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
        if (item != null)
          return new DocumentModel.Wordprocessing.IndentationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Indentation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.IndentationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  public Boolean? ContextualSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.ContextualSpacing();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  public Boolean? MirrorIndents
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MirrorIndents>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.MirrorIndents();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  public Boolean? SuppressOverlap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.SuppressOverlap();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Wordprocessing.JustificationKind? Justification
  {
    get => (DocumentModel.Wordprocessing.JustificationKind?)OpenXmlElement?.Justification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Justification != null)
        {
          if (value is not null)
            OpenXmlElement.Justification.Val = (DocumentFormat.OpenXml.Wordprocessing.JustificationValues?)value;
          else
            OpenXmlElement.Justification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Justification = new DocumentFormat.OpenXml.Wordprocessing.Justification{ Val = (DocumentFormat.OpenXml.Wordprocessing.JustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection
  {
    get => (DocumentModel.Wordprocessing.TextDirectionKind?)OpenXmlElement?.TextDirection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextDirection != null)
        {
          if (value is not null)
            OpenXmlElement.TextDirection.Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value;
          else
            OpenXmlElement.TextDirection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextDirection = new DocumentFormat.OpenXml.Wordprocessing.TextDirection{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalTextAlignmentKind? TextAlignment
  {
    get => (DocumentModel.Wordprocessing.VerticalTextAlignmentKind?)OpenXmlElement?.TextAlignment?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextAlignment != null)
        {
          if (value is not null)
            OpenXmlElement.TextAlignment.Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues?)value;
          else
            OpenXmlElement.TextAlignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextAlignment = new DocumentFormat.OpenXml.Wordprocessing.TextAlignment{ Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.TextBoxTightWrapKind? TextBoxTightWrap
  {
    get => (DocumentModel.Wordprocessing.TextBoxTightWrapKind?)OpenXmlElement?.TextBoxTightWrap?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TextBoxTightWrap != null)
        {
          if (value is not null)
            OpenXmlElement.TextBoxTightWrap.Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues?)value;
          else
            OpenXmlElement.TextBoxTightWrap = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TextBoxTightWrap = new DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrap{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  public Int32? OutlineLevel
  {
    get => (System.Int32?)OpenXmlElement?.OutlineLevel?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OutlineLevel != null)
        {
          if (value is not null)
            OpenXmlElement.OutlineLevel.Val = (System.Int32?)value;
          else
            OpenXmlElement.OutlineLevel = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OutlineLevel = new DocumentFormat.OpenXml.Wordprocessing.OutlineLevel{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
}
