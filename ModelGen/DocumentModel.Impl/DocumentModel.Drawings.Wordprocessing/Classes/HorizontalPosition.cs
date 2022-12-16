namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public class HorizontalPositionImpl: ModelElementImpl, HorizontalPosition
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HorizontalPositionImpl(): base() {}
  
  public HorizontalPositionImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? RelativeFrom
  {
    get => (DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind?)OpenXmlElement?.RelativeFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeFrom = (DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public String? HorizontalAlignment
  {
    get => (System.String?)OpenXmlElement?.HorizontalAlignment?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HorizontalAlignment != null)
        {
          if (value is not null)
            OpenXmlElement.HorizontalAlignment.Text = value;
          else
            OpenXmlElement.HorizontalAlignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HorizontalAlignment = new DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public String? PositionOffset
  {
    get => (System.String?)OpenXmlElement?.PositionOffset?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PositionOffset != null)
        {
          if (value is not null)
            OpenXmlElement.PositionOffset.Text = value;
          else
            OpenXmlElement.PositionOffset = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PositionOffset = new DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionHeightOffset
  {
    get => (System.String?)OpenXmlElement?.PercentagePositionHeightOffset?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentagePositionHeightOffset != null)
        {
          if (value is not null)
            OpenXmlElement.PercentagePositionHeightOffset.Text = value;
          else
            OpenXmlElement.PercentagePositionHeightOffset = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentagePositionHeightOffset = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset{ Text = value };
        }
      }
    }
  }
  
}
