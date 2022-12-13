namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Cell Properties.
/// </summary>
public class PreviousTableCellPropertiesImpl: ModelElementImpl, PreviousTableCellProperties
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellWidth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellDeletion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.CellMerge? CellMerge
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
