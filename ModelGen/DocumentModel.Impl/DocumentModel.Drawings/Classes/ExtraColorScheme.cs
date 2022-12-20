namespace DocumentModel.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public partial class ExtraColorSchemeImpl: ModelElementImpl, ExtraColorScheme
{
  public DocumentFormat.OpenXml.Drawing.ExtraColorScheme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtraColorScheme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtraColorSchemeImpl(): base() {}
  
  public ExtraColorSchemeImpl(DocumentFormat.OpenXml.Drawing.ExtraColorScheme openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
        if (item != null)
          return new DocumentModel.Drawings.ColorSchemeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorScheme>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ColorSchemeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public DocumentModel.Drawings.ColorMap? ColorMap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
        if (item != null)
          return new DocumentModel.Drawings.ColorMapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorMap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ColorMapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
