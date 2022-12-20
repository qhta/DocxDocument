namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualGroupDrawingShapePropertiesImpl: ModelElementImpl, NonVisualGroupDrawingShapeProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupDrawingShapePropertiesImpl(): base() {}
  
  public NonVisualGroupDrawingShapePropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties openXmlElement): base(openXmlElement)
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
