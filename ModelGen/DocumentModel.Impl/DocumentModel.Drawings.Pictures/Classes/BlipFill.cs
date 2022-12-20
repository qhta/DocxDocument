namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Picture Fill.
/// </summary>
public partial class BlipFillImpl: ModelElementImpl, BlipFill
{
  public DocumentFormat.OpenXml.Drawing.Pictures.BlipFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Pictures.BlipFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BlipFillImpl(): base() {}
  
  public BlipFillImpl(DocumentFormat.OpenXml.Drawing.Pictures.BlipFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// DPI Setting
  /// </summary>
  public UInt32? Dpi
  {
    get => (System.UInt32?)OpenXmlElement?.Dpi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dpi = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape
  {
    get => (System.Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawings.Blip? Blip
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
        if (item != null)
          return new DocumentModel.Drawings.BlipImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blip>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BlipImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? SourceRectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          return new DocumentModel.Drawings.RelativeRectangleTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RelativeRectangleType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RelativeRectangleTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Tile? Tile
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
        if (item != null)
          return new DocumentModel.Drawings.TileImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tile>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TileImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Stretch? Stretch
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
        if (item != null)
          return new DocumentModel.Drawings.StretchImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Stretch>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.StretchImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
