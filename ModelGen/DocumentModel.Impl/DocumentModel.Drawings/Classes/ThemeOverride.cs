namespace DocumentModel.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public partial class ThemeOverrideImpl: ModelElementImpl, ThemeOverride
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ThemeOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ThemeOverride?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ThemeOverrideImpl(): base() {}
  
  public ThemeOverrideImpl(DocumentFormat.OpenXml.Drawing.ThemeOverride openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Color Scheme.
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
  /// FontScheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
        if (item != null)
          return new DocumentModel.Drawings.FontSchemeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontScheme>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.FontSchemeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
        if (item != null)
          return new DocumentModel.Drawings.FormatSchemeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FormatScheme>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.FormatSchemeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
