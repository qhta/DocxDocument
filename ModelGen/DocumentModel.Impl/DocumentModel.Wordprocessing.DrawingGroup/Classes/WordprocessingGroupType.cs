namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the WordprocessingGroupType Class.
/// </summary>
public partial class WordprocessingGroupTypeImpl: ModelElementImpl, WordprocessingGroupType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroupType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroupType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WordprocessingGroupTypeImpl(): base() {}
  
  public WordprocessingGroupTypeImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroupType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGroupDrawingShapeProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGroupDrawingShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.DrawingGroup.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GroupShapeProperties>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.GroupShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GroupShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.GroupShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
