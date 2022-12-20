namespace DocumentModel.UI;

/// <summary>
/// Defines the RepurposedCommand Class.
/// </summary>
public partial class RepurposedCommandImpl: ModelElementImpl, RepurposedCommand
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RepurposedCommandImpl(): base() {}
  
  public RepurposedCommandImpl(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
}
