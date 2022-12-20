namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Inline DrawingML Object.
/// </summary>
public partial class InlineImpl: ModelElementImpl, Inline
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public InlineImpl(): base() {}
  
  public InlineImpl(DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public UInt32? DistanceFromTop
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromTop = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public UInt32? DistanceFromBottom
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromBottom = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromLeft = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight
  {
    get => (System.UInt32?)OpenXmlElement?.DistanceFromRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DistanceFromRight = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinary? AnchorId
  {
    get
    {
      if (OpenXmlElement?.AnchorId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.AnchorId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.AnchorId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.AnchorId = null;
      }
    }
  }
  
  /// <summary>
  /// editId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinary? EditId
  {
    get
    {
      if (OpenXmlElement?.EditId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.EditId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.EditId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.EditId = null;
      }
    }
  }
  
  /// <summary>
  /// Drawing Object Size.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Extent? Extent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.ExtentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.ExtentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Inline Wrapping Extent.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.EffectExtent? EffectExtent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.EffectExtentImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.EffectExtentImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Drawing Object Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.DocProperties? DocProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.DocPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.DocPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Common DrawingML Non-Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Graphic.
  /// </summary>
  public DocumentModel.Drawings.Graphic? Graphic
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
