namespace DocumentModel;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public partial class ThemeFamilyImpl: ModelElementImpl, ThemeFamily
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ThemeFamilyImpl(): base() {}
  
  public ThemeFamilyImpl(DocumentFormat.OpenXml.Office2013.Theme.ThemeFamily openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
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
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Vid
  {
    get => (System.String?)OpenXmlElement?.Vid?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Vid = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
