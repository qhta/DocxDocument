namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Cell Properties.
/// </summary>
public partial class PreviousTableCellPropertiesImpl: ModelElementImpl, PreviousTableCellProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreviousTableCellPropertiesImpl(): base() {}
  
  public PreviousTableCellPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousTableCellProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.ConditionalFormatStyle? ConditionalFormatStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ConditionalFormatStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ConditionalFormatStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableWidthTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableWidthTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  public Int32? GridSpan
  {
    get => (System.Int32?)OpenXmlElement?.GridSpan?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.GridSpan != null)
        {
          if (value is not null)
            OpenXmlElement.GridSpan.Val = (System.Int32?)value;
          else
            OpenXmlElement.GridSpan = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.GridSpan = new DocumentFormat.OpenXml.Wordprocessing.GridSpan{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? HorizontalMerge
  {
    get => (DocumentModel.Wordprocessing.MergedCellKind?)OpenXmlElement?.HorizontalMerge?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HorizontalMerge != null)
        {
          if (value is not null)
            OpenXmlElement.HorizontalMerge.Val = (DocumentFormat.OpenXml.Wordprocessing.MergedCellValues?)value;
          else
            OpenXmlElement.HorizontalMerge = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HorizontalMerge = new DocumentFormat.OpenXml.Wordprocessing.HorizontalMerge{ Val = (DocumentFormat.OpenXml.Wordprocessing.MergedCellValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? VerticalMerge
  {
    get => (DocumentModel.Wordprocessing.MergedCellKind?)OpenXmlElement?.VerticalMerge?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.VerticalMerge != null)
        {
          if (value is not null)
            OpenXmlElement.VerticalMerge.Val = (DocumentFormat.OpenXml.Wordprocessing.MergedCellValues?)value;
          else
            OpenXmlElement.VerticalMerge = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.VerticalMerge = new DocumentFormat.OpenXml.Wordprocessing.VerticalMerge{ Val = (DocumentFormat.OpenXml.Wordprocessing.MergedCellValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellBorders? TableCellBorders
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableCellBordersImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableCellBordersImpl)?.OpenXmlElement;
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
  /// NoWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoWrap
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.NoWrap?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NoWrap != null)
        {
          if (value is not null)
            OpenXmlElement.NoWrap.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.NoWrap = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NoWrap = new DocumentFormat.OpenXml.Wordprocessing.NoWrap{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMargin? TableCellMargin
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TableCellMarginImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TableCellMarginImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
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
  /// TableCellFitText.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableCellFitText
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.TableCellFitText?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableCellFitText != null)
        {
          if (value is not null)
            OpenXmlElement.TableCellFitText.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.TableCellFitText = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableCellFitText = new DocumentFormat.OpenXml.Wordprocessing.TableCellFitText{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get => (DocumentModel.Wordprocessing.TableVerticalAlignmentKind?)OpenXmlElement?.TableCellVerticalAlignment?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TableCellVerticalAlignment != null)
        {
          if (value is not null)
            OpenXmlElement.TableCellVerticalAlignment.Val = (DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues?)value;
          else
            OpenXmlElement.TableCellVerticalAlignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TableCellVerticalAlignment = new DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment{ Val = (DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? HideMark
  {
    get => (DocumentModel.Wordprocessing.OnOffOnlyKind?)OpenXmlElement?.HideMark?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideMark != null)
        {
          if (value is not null)
            OpenXmlElement.HideMark.Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value;
          else
            OpenXmlElement.HideMark = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideMark = new DocumentFormat.OpenXml.Wordprocessing.HideMark{ Val = (DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues?)value };
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellInsertion
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TrackChangeTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TrackChangeTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellDeletion
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TrackChangeTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TrackChangeTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.CellMerge? CellMerge
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellMerge>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CellMergeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CellMerge>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CellMergeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
