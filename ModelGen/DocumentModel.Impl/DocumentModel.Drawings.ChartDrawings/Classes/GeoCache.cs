namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public partial class GeoCacheImpl: ModelElementImpl, GeoCache
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GeoCacheImpl(): base() {}
  
  public GeoCacheImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Provider
  {
    get => (System.String?)OpenXmlElement?.Provider?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Provider = (System.String?)value;
    }
  }
  
  public String? Xsdbase64Binary
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsdbase64Binary>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsdbase64Binary>();
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
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Xsdbase64Binary{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ChartDrawings.Clear? Clear
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ClearImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Clear>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ClearImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
