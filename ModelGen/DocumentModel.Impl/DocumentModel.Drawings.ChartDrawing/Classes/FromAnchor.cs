namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public partial class FromAnchorImpl: DocumentModel.Drawings.ChartDrawing.MarkerTypeImpl, FromAnchor
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FromAnchorImpl(): base() {}
  
  public FromAnchorImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? XPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new String? YPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
