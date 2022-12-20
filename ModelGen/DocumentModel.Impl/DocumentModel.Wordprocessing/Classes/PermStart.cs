namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public partial class PermStartImpl: ModelElementImpl, PermStart
{
  public DocumentFormat.OpenXml.Wordprocessing.PermStart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PermStart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PermStartImpl(): base() {}
  
  public PermStartImpl(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// edGrp
  /// </summary>
  public DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? EditorGroup
  {
    get => (DocumentModel.Wordprocessing.RangePermissionEditingGroupKind?)OpenXmlElement?.EditorGroup?.Value;
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
    get => (System.String?)OpenXmlElement?.Ed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Ed = (System.String?)value;
    }
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst
  {
    get => (System.Int32?)OpenXmlElement?.ColumnFirst?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnFirst = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast
  {
    get => (System.Int32?)OpenXmlElement?.ColumnLast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnLast = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id
  {
    get => (System.Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DocumentModel.Wordprocessing.DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
}
