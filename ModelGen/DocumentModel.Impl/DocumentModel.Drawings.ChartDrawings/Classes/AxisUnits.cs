namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public partial class AxisUnitsImpl: ModelElementImpl, AxisUnits
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AxisUnitsImpl(): base() {}
  
  public AxisUnitsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.AxisUnit? Unit
  {
    get => (DocumentModel.Drawings.ChartDrawings.AxisUnit?)OpenXmlElement?.Unit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Unit = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit?)value;
    }
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? AxisUnitsLabel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.AxisUnitsLabelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.AxisUnitsLabelImpl)?.OpenXmlElement;
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
