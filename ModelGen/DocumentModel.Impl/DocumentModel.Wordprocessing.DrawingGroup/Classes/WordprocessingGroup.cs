namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the WordprocessingGroup Class.
/// </summary>
public partial class WordprocessingGroupImpl: DocumentModel.Wordprocessing.DrawingGroup.WordprocessingGroupTypeImpl, WordprocessingGroup
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WordprocessingGroupImpl(): base() {}
  
  public WordprocessingGroupImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties
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
  
  public new DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
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
  
  public new DocumentModel.Wordprocessing.DrawingGroup.GroupShapeProperties? GroupShapeProperties
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
  
  public DocumentModel.Wordprocessing.DrawingShape.WordprocessingShape? WordprocessingShape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingShape.WordprocessingShapeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingShape.WordprocessingShapeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DrawingGroup.GroupShape? GroupShape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GroupShape>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.GroupShapeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GroupShape>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.GroupShapeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DrawingGroup.GraphicFrame? GraphicFrame
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GraphicFrame>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.GraphicFrameImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GraphicFrame>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.GraphicFrameImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Pictures.Picture? Picture
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.Picture>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.PictureImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.Picture>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.PictureImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.ContentPart2? ContentPart
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContentPart>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ContentPart2Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContentPart>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ContentPart2Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
