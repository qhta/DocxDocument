namespace DocumentModel.Drawings;

/// <summary>
/// Theme.
/// </summary>
public partial class ThemeImpl: ModelElementImpl, Theme
{
  public DocumentFormat.OpenXml.Drawing.Theme? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Theme?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ThemeImpl(): base() {}
  
  public ThemeImpl(DocumentFormat.OpenXml.Drawing.Theme openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ThemeId
  {
    get => (System.String?)OpenXmlElement?.ThemeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public DocumentModel.Drawings.ThemeElements? ThemeElements
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
        if (item != null)
          return new DocumentModel.Drawings.ThemeElementsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ThemeElements>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ThemeElementsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public DocumentModel.Drawings.ObjectDefaults? ObjectDefaults
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
        if (item != null)
          return new DocumentModel.Drawings.ObjectDefaultsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ObjectDefaults>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ObjectDefaultsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public DocumentModel.Drawings.ExtraColorSchemeList? ExtraColorSchemeList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtraColorSchemeListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtraColorSchemeListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public DocumentModel.Drawings.CustomColorList? CustomColorList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
        if (item != null)
          return new DocumentModel.Drawings.CustomColorListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomColorList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.CustomColorListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.OfficeStyleSheetExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OfficeStyleSheetExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Gets the ThemePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.ThemePart? ThemePart
  {
    get
    {
      if (OpenXmlElement?.ThemePart != null)
        return new DocumentModel.Packaging.ThemePartImpl(OpenXmlElement.ThemePart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.ThemePartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
}
