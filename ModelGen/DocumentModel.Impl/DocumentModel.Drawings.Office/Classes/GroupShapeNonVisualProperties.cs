namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public partial class GroupShapeNonVisualPropertiesImpl: ModelElementImpl, GroupShapeNonVisualProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupShapeNonVisualPropertiesImpl(): base() {}
  
  public GroupShapeNonVisualPropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.NonVisualGroupDrawingShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.NonVisualGroupDrawingShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
