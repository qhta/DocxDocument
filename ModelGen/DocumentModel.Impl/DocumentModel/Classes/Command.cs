namespace DocumentModel;

/// <summary>
/// Defines the Command Class.
/// </summary>
public partial class CommandImpl: ModelElementImpl, Command
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.Command? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.Command?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CommandImpl(): base() {}
  
  public CommandImpl(DocumentFormat.OpenXml.Office2010.CustomUI.Command openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// idMso, this property is only available in Office 2010 and later.
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
  
}
