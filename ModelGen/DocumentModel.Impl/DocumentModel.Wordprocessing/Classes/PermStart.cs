namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public class PermStartImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>, PermStart
{
  /// <summary>
  /// edGrp
  /// </summary>
  public RangePermissionEditingGroupKind? EditorGroup
  {
    get => (RangePermissionEditingGroupKind?)OpenXmlElement?.EditorGroup?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EditorGroup = (DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues?)value;
    }
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
}
