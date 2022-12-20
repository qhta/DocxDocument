namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public partial class VerticalPositionImpl: ModelElementImpl, VerticalPosition
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VerticalPositionImpl(): base() {}
  
  public VerticalPositionImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? RelativeFrom
  {
    get => (DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind?)OpenXmlElement?.RelativeFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeFrom = (DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  public String? VerticalAlignment
  {
    get => (System.String?)OpenXmlElement?.VerticalAlignment?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.VerticalAlignment != null)
        {
          if (value is not null)
            OpenXmlElement.VerticalAlignment.Text = value;
          else
            OpenXmlElement.VerticalAlignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.VerticalAlignment = new DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// PositionOffset.
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
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionVerticalOffset
  {
    get => (System.String?)OpenXmlElement?.PercentagePositionVerticalOffset?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentagePositionVerticalOffset != null)
        {
          if (value is not null)
            OpenXmlElement.PercentagePositionVerticalOffset.Text = value;
          else
            OpenXmlElement.PercentagePositionVerticalOffset = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentagePositionVerticalOffset = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset{ Text = value };
        }
      }
    }
  }
  
}
