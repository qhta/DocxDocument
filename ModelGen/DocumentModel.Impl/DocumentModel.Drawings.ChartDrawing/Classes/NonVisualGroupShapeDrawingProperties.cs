namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public partial class NonVisualGroupShapeDrawingPropertiesImpl: ModelElementImpl, NonVisualGroupShapeDrawingProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupShapeDrawingPropertiesImpl(): base() {}
  
  public NonVisualGroupShapeDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeLocks? GroupShapeLocks
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
        if (item != null)
          return new DocumentModel.Drawings.GroupShapeLocksImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GroupShapeLocksImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
