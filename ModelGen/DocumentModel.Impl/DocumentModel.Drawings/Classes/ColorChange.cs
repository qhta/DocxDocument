namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public partial class ColorChangeImpl: ModelElementImpl, ColorChange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ColorChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorChange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorChangeImpl(): base() {}
  
  public ColorChangeImpl(DocumentFormat.OpenXml.Drawing.ColorChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha
  {
    get => (System.Boolean?)OpenXmlElement?.UseAlpha?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseAlpha = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public DocumentModel.Drawings.ColorFrom? ColorFrom
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
        if (item != null)
          return new DocumentModel.Drawings.ColorFromImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorFrom>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ColorFromImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public DocumentModel.Drawings.ColorTo? ColorTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
        if (item != null)
          return new DocumentModel.Drawings.ColorToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ColorToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
