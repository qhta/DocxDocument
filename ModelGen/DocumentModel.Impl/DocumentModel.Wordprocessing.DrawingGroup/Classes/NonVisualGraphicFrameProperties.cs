namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the NonVisualGraphicFrameProperties Class.
/// </summary>
public partial class NonVisualGraphicFramePropertiesImpl: ModelElementImpl, NonVisualGraphicFrameProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualGraphicFramePropertiesImpl(): base() {}
  
  public NonVisualGraphicFramePropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawings.GraphicFrameLocks? GraphicFrameLocks
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicFrameLocksImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicFrameLocksImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
