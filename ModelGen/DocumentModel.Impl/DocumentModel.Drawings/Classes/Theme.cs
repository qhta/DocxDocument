namespace DocumentModel.Drawings;

/// <summary>
/// Theme.
/// </summary>
public class ThemeImpl: ModelElementImpl, Theme
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
    get => (String?)OpenXmlElement?.Name?.Value;
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
    get => (String?)OpenXmlElement?.ThemeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ThemeElements.
  /// </summary>
  public ThemeElements? ThemeElements
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ObjectDefaults.
  /// </summary>
  public ObjectDefaults? ObjectDefaults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtraColorSchemeList.
  /// </summary>
  public ExtraColorSchemeList? ExtraColorSchemeList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// CustomColorList.
  /// </summary>
  public CustomColorList? CustomColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OfficeStyleSheetExtensionList.
  /// </summary>
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
