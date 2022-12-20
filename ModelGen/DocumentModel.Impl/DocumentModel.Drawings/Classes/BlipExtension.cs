namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public partial class BlipExtensionImpl: ModelElementImpl, BlipExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.BlipExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BlipExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BlipExtensionImpl(): base() {}
  
  public BlipExtensionImpl(DocumentFormat.OpenXml.Drawing.BlipExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.ImageProperties? ImageProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ImagePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ImagePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? UseLocalDpi
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2010.Drawing.UseLocalDpi{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Wordprocessing.WebVideoProperty? WebVideoProperty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
        if (item != null)
          return new DocumentModel.Drawings.Wordprocessing.WebVideoPropertyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Wordprocessing.WebVideoPropertyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.SVG.SVGBlip? SVGBlip
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
        if (item != null)
          return new DocumentModel.Drawings.SVG.SVGBlipImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SVG.SVGBlipImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.PictureAttributionSourceURL? PictureAttributionSourceURL
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
        if (item != null)
          return new DocumentModel.Drawings.PictureAttributionSourceURLImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PictureAttributionSourceURLImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.OEmbed.OEmbed? OEmbed
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
        if (item != null)
          return new DocumentModel.Wordprocessing.OEmbed.OEmbedImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.OEmbed.OEmbedImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Office.OEmbed.OEmbedShared? OEmbedShared
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
        if (item != null)
          return new DocumentModel.Drawings.Office.OEmbed.OEmbedSharedImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.OEmbed.OEmbedSharedImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
