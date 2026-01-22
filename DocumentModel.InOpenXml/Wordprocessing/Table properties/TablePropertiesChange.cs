namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a change to table properties, used in <see cref = "TableProperties"/>.
///   This interface annotates <see cref = "PreviousTableProperties"/> with author, date, and annotation identifier, enabling tracking and management of property revisions for tables.
/// </summary>
public partial class TablePropertiesChange : ModelElement<DXW.TablePropertiesChange>
{
    /// <summary>
    ///   Author of the change to the table properties.
    /// </summary>
    public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }

    private string? _Author;
    /// <summary>
    ///   Date of the change to the table properties.
    /// </summary>
    public DateTime? Date { get; set; }
    /// <summary>
    ///   Annotation identifier for the change, used to uniquely identify the revision.
    /// </summary>
    public string? AnnotationId { get; set; }
    /// <summary>
    ///   Previous table properties before the change, enabling comparison and tracking of revisions.
    /// </summary>
    public PreviousTableProperties? PreviousTableProperties { get; set; }
}