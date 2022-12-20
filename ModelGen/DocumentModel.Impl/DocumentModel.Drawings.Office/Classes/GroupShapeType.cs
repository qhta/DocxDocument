namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeTypeImpl: ModelElementImpl, GroupShapeType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.GroupShapeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShapeType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GroupShapeTypeImpl(): base() {}
  
  public GroupShapeTypeImpl(DocumentFormat.OpenXml.Office.Drawing.GroupShapeType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.GroupShapeNonVisualPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.GroupShapeNonVisualPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Office.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.GroupShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.GroupShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
