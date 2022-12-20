namespace DocumentModel.UI;

/// <summary>
/// Defines the CheckBox Class.
/// </summary>
public partial class CheckBoxImpl: ModelElementImpl, CheckBox
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.CheckBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.CheckBox?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CheckBoxImpl(): base() {}
  
  public CheckBoxImpl(DocumentFormat.OpenXml.Office.CustomUI.CheckBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// getPressed
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
  /// onAction
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
  
}
