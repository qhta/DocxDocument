namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public partial class DataPointImpl: ModelElementImpl, DataPoint
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DataPointImpl(): base() {}
  
  public DataPointImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (System.UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
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
