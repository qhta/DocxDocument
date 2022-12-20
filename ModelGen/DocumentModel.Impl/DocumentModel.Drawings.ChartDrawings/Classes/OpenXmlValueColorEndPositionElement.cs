namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public partial class OpenXmlValueColorEndPositionElementImpl: ModelElementImpl, OpenXmlValueColorEndPositionElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlValueColorEndPositionElementImpl(): base() {}
  
  public OpenXmlValueColorEndPositionElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public virtual Boolean? ExtremeValueColorPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public virtual Double? NumberColorPosition
  {
    get => (System.Double?)OpenXmlElement?.NumberColorPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberColorPosition != null)
        {
          if (value is not null)
            OpenXmlElement.NumberColorPosition.Val = (System.Double?)value;
          else
            OpenXmlElement.NumberColorPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberColorPosition = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public virtual Double? PercentageColorPosition
  {
    get => (System.Double?)OpenXmlElement?.PercentageColorPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentageColorPosition != null)
        {
          if (value is not null)
            OpenXmlElement.PercentageColorPosition.Val = (System.Double?)value;
          else
            OpenXmlElement.PercentageColorPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentageColorPosition = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = (System.Double?)value };
        }
      }
    }
  }
  
}
