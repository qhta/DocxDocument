namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public partial class ChartDataImpl: ModelElementImpl, ChartData
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChartDataImpl(): base() {}
  
  public ChartDataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExternalData? ExternalData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExternalDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExternalDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ChartDrawings.Data? Data
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.DataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.DataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
