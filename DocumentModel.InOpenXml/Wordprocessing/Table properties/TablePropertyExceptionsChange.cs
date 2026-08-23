namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to table property exceptions, used in <see cref = "TablePropertyExceptions"/>.
/// This class annotates <see cref = "PreviousTablePropertyExceptions"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for table-level exceptions.
/// </summary>
[OpenXmlType(typeof(DXW.TablePropertyExceptionsChange))]
[DataContract]
[XmlRoot("TablePropertyExceptionsChange", Namespace = "DocumentModel.Wordprocessing")]
public partial class TablePropertyExceptionsChange : IdentifiedChange<DXW.TablePropertyExceptionsChange>
{
  /// <summary>
  /// Annotation identifier for the change, used to uniquely identify the revision.
  /// </summary>
  public string? AnnotationId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Previous table-level property exceptions before the change, enabling comparison and tracking of revisions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}