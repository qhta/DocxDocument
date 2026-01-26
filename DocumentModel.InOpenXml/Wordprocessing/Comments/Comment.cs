namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a single comment annotation stored in the Comments part of a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and <see cref = "ElementCollection{CommentContent}"/>, providing properties for unique identification, author attribution, initials, creation/modification date, paragraph identifier, and durable identifier. Enables advanced tracking, management, and collaborative review of comments, supporting rich text, threaded discussions, and persistent references across document versions and platforms.
/// </summary>
[OpenXmlType(typeof(DXW.Comment))]
public partial class Comment : ModelElement<DXW.Comment>
{
 /// <summary>
 /// Unique identifier for this comment annotation, used to link comment range markers, associate replies, and reference comments in revision tracking.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Comment.Id))]
 /// <summary>
 /// Unique identifier for this comment annotation, used to link comment range markers, associate replies, and reference comments in revision tracking.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 /// FontName of the author who created this comment, displayed in the comment balloon and review pane for attribution.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Comment.Author))]
 /// <summary>
 /// FontName of the author who created this comment, displayed in the comment balloon and review pane for attribution.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }

 private string? _Author;
 /// <summary>
 /// Initials of the comment author, providing a compact representation for display in user interfaces and comment blocks.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Comment.Initials))]
 /// <summary>
 /// Initials of the comment author, providing a compact representation for display in user interfaces and comment blocks.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public string? Initials { get => _Initials; set => UpdateField(ref _Initials, value, nameof(Initials)); }

 private string? _Initials;
 /// <summary>
 /// Date and time when this comment was created or last modified, providing temporal context for document review activities.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Comment.Date))]
 /// <summary>
 /// Date and time when this comment was created or last modified, providing temporal context for document review activities.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public DateTime? Date { get => _Date; set => UpdateField(ref _Date, value, nameof(Date)); }

 private DateTime? _Date;
 /// <summary>
 /// Hexadecimal identifier of the first paragraph in the comment content, used for tracking paragraph-level changes and synchronization.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public HexInt? ParaId { get => _ParaId; set => UpdateField(ref _ParaId, value, nameof(ParaId)); }

 private HexInt? _ParaId;
 /// <summary>
 /// Durable identifier that persists across document versions and platforms, supporting consistent comment tracking and synchronization.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Comment))]
 public HexInt? DurableId { get => _DurableId; set => UpdateField(ref _DurableId, value, nameof(DurableId)); }

 private HexInt? _DurableId;
}