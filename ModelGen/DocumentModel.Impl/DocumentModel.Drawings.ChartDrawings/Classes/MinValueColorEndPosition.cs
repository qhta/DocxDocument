namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public class MinValueColorEndPositionImpl: DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElementImpl, MinValueColorEndPosition
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinValueColorEndPositionImpl(): base() {}
  
  public MinValueColorEndPositionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new Boolean? ExtremeValueColorPosition
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
  
  public new Double? NumberColorPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
        return (System.Double?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new Double? PercentageColorPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
        return (System.Double?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
