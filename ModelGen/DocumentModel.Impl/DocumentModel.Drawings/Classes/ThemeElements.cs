namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public partial class ThemeElementsImpl: ModelElementImpl, ThemeElements
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.ThemeElements? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ThemeElements?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ThemeElementsImpl(): base() {}
  
  public ThemeElementsImpl(DocumentFormat.OpenXml.Drawing.ThemeElements openXmlElement): base(openXmlElement)
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
  /// Font Scheme.
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
  /// Format Scheme.
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
