namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public class PermStartImpl: ModelElementImpl, PermStart
{
  public DocumentFormat.OpenXml.Wordprocessing.PermStart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PermStart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  /// ed
  /// </summary>
  public String? Ed
  {
    get;
    set;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id
  {
    get;
    set;
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
