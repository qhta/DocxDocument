namespace DocumentModel.UI;

/// <summary>
/// Defines the DynamicMenu Class.
/// </summary>
public partial class DynamicMenuImpl: ModelElementImpl, DynamicMenu
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DynamicMenuImpl(): base() {}
  
  public DynamicMenuImpl(DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// size
  /// </summary>
  public DocumentModel.UI.SizeKind? Size
  {
    get => (DocumentModel.UI.SizeKind?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (DocumentFormat.OpenXml.Office.CustomUI.SizeValues?)value;
    }
  }
  
  /// <summary>
  /// getSize
  /// </summary>
  public String? GetSize
  {
    get => (System.String?)OpenXmlElement?.GetSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// description
  /// </summary>
  public String? Description
  {
    get => (System.String?)OpenXmlElement?.Description?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  public String? GetDescription
  {
    get => (System.String?)OpenXmlElement?.GetDescription?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetDescription = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id
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
  /// idQ
  /// </summary>
  public String? IdQ
  {
    get => (System.String?)OpenXmlElement?.IdQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public String? IdMso
  {
    get => (System.String?)OpenXmlElement?.IdMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public String? Tag
  {
    get => (System.String?)OpenXmlElement?.Tag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tag = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getContent
  /// </summary>
  public String? GetContent
  {
    get => (System.String?)OpenXmlElement?.GetContent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetContent = (System.String?)value;
    }
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  public Boolean? InvalidateContentOnDrop
  {
    get => (System.Boolean?)OpenXmlElement?.InvalidateContentOnDrop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvalidateContentOnDrop = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// image
  /// </summary>
  public String? Image
  {
    get => (System.String?)OpenXmlElement?.Image?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Image = (System.String?)value;
    }
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public String? ImageMso
  {
    get => (System.String?)OpenXmlElement?.ImageMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  public String? GetImage
  {
    get => (System.String?)OpenXmlElement?.GetImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public String? Screentip
  {
    get => (System.String?)OpenXmlElement?.Screentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Screentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public String? GetScreentip
  {
    get => (System.String?)OpenXmlElement?.GetScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public String? Supertip
  {
    get => (System.String?)OpenXmlElement?.Supertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Supertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public String? GetSupertip
  {
    get => (System.String?)OpenXmlElement?.GetSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public Boolean? Enabled
  {
    get => (System.Boolean?)OpenXmlElement?.Enabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enabled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public String? GetEnabled
  {
    get => (System.String?)OpenXmlElement?.GetEnabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetEnabled = (System.String?)value;
    }
  }
  
  /// <summary>
  /// label
  /// </summary>
  public String? Label
  {
    get => (System.String?)OpenXmlElement?.Label?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Label = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public String? GetLabel
  {
    get => (System.String?)OpenXmlElement?.GetLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public String? InsertAfterMso
  {
    get => (System.String?)OpenXmlElement?.InsertAfterMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ
  {
    get => (System.String?)OpenXmlElement?.InsertAfterQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible
  {
    get => (System.String?)OpenXmlElement?.GetVisible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetVisible = (System.String?)value;
    }
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public String? Keytip
  {
    get => (System.String?)OpenXmlElement?.Keytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public String? GetKeytip
  {
    get => (System.String?)OpenXmlElement?.GetKeytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetKeytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public Boolean? ShowLabel
  {
    get => (System.Boolean?)OpenXmlElement?.ShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public String? GetShowLabel
  {
    get => (System.String?)OpenXmlElement?.GetShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  public Boolean? ShowImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public String? GetShowImage
  {
    get => (System.String?)OpenXmlElement?.GetShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowImage = (System.String?)value;
    }
  }
  
}
