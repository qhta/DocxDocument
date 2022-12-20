namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public partial class SurfaceTypeImpl: ModelElementImpl, SurfaceType
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceTypeImpl(): base() {}
  
  public SurfaceTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Thickness.
  /// </summary>
  public virtual Byte? Thickness
  {
    get => (System.Byte?)OpenXmlElement?.Thickness?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Thickness != null)
        {
          if (value is not null)
            OpenXmlElement.Thickness.Val = (System.Byte?)value;
          else
            OpenXmlElement.Thickness = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Thickness = new DocumentFormat.OpenXml.Drawing.Charts.Thickness{ Val = (System.Byte?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.PictureOptions? PictureOptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PictureOptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PictureOptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
