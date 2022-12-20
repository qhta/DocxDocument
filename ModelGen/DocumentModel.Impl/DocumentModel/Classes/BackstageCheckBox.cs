namespace DocumentModel;

/// <summary>
/// Defines the BackstageCheckBox Class.
/// </summary>
public partial class BackstageCheckBoxImpl: ModelElementImpl, BackstageCheckBox
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageCheckBoxImpl(): base() {}
  
  public BackstageCheckBoxImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox openXmlElement): base(openXmlElement)
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
  /// description, this property is only available in Office 2010 and later.
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
  /// getDescription, this property is only available in Office 2010 and later.
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
  /// getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetPressed
  {
    get => (System.String?)OpenXmlElement?.GetPressed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetPressed = (System.String?)value;
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
  
}
