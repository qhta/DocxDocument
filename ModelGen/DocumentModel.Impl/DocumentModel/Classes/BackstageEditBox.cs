namespace DocumentModel;

/// <summary>
/// Defines the BackstageEditBox Class.
/// </summary>
public partial class BackstageEditBoxImpl: ModelElementImpl, BackstageEditBox
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageEditBoxImpl(): base() {}
  
  public BackstageEditBoxImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? AlignLabel
  {
    get => (DocumentModel.ExpandKind?)OpenXmlElement?.AlignLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlignLabel = (DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues?)value;
    }
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
  /// getText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetText
  {
    get => (System.String?)OpenXmlElement?.GetText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetText = (System.String?)value;
    }
  }
  
  /// <summary>
  /// onChange, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnChange
  {
    get => (System.String?)OpenXmlElement?.OnChange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnChange = (System.String?)value;
    }
  }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MaxLength
  {
    get => (System.Int32?)OpenXmlElement?.MaxLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxLength = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SizeString
  {
    get => (System.String?)OpenXmlElement?.SizeString?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SizeString = (System.String?)value;
    }
  }
  
}
