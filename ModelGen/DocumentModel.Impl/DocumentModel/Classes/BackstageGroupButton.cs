namespace DocumentModel;

/// <summary>
/// Defines the BackstageGroupButton Class.
/// </summary>
public partial class BackstageGroupButtonImpl: ModelElementImpl, BackstageGroupButton
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageGroupButtonImpl(): base() {}
  
  public BackstageGroupButtonImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Expand
  {
    get => (DocumentModel.ExpandKind?)OpenXmlElement?.Expand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Expand = (DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues?)value;
    }
  }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Style2Kind? Style
  {
    get => (DocumentModel.Style2Kind?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values?)value;
    }
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
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
  /// getScreentip, this property is only available in Office 2010 and later.
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
  /// supertip, this property is only available in Office 2010 and later.
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
  /// getSupertip, this property is only available in Office 2010 and later.
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
  /// id, this property is only available in Office 2010 and later.
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
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId
  {
    get => (System.String?)OpenXmlElement?.QualifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QualifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
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
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnAction
  {
    get => (System.String?)OpenXmlElement?.OnAction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnAction = (System.String?)value;
    }
  }
  
  /// <summary>
  /// isDefinitive, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsDefinitive
  {
    get => (System.Boolean?)OpenXmlElement?.IsDefinitive?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsDefinitive = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
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
  /// getEnabled, this property is only available in Office 2010 and later.
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
  /// label, this property is only available in Office 2010 and later.
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
  /// getLabel, this property is only available in Office 2010 and later.
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
  /// visible, this property is only available in Office 2010 and later.
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
  /// getVisible, this property is only available in Office 2010 and later.
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
  /// keytip, this property is only available in Office 2010 and later.
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
  /// getKeytip, this property is only available in Office 2010 and later.
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
  /// image, this property is only available in Office 2010 and later.
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
  /// imageMso, this property is only available in Office 2010 and later.
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
  /// getImage, this property is only available in Office 2010 and later.
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
  
}
