namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents revision information for table grid column definitions in a Wordprocessing document.
/// This class provides properties for annotation identification and previous table grid configuration, enabling tracking and management of grid revisions.
/// </summary>
[OpenXmlType(typeof(DXW.TableGridChange))]
public partial class TableGridChange : ModelElement<DXW.TableGridChange>
{
 /// <summary>
 /// Annotation identifier for the table grid change, used to uniquely identify the revision.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableGridChange))]
 public string? AnnotationId { get => _AnnotationId; set => UpdateField(ref _AnnotationId, value, nameof(AnnotationId)); }

 private string? _AnnotationId;
 /// <summary>
 /// Previous table grid configuration before the change, enabling comparison and tracking of grid revisions.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableGridChange.PreviousTableGrid))]
 [OpenXmlElement(typeof(DXW.TableGridChange))]
 public PreviousTableGrid? PreviousTableGrid { get => _PreviousTableGrid; set => UpdateField(ref _PreviousTableGrid, value, nameof(PreviousTableGrid)); }

 private PreviousTableGrid? _PreviousTableGrid;
}