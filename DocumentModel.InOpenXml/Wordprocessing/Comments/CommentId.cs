namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents identifiers for a comment in a WordprocessingML document, providing both paragraph-level and durable identification.
///   This class extends <see cref = "CollectionItem"/> and enables stable references to comments for tracking, synchronization, and platform transitions. It supports paragraph-level tracking and global identification for collaborative editing and document operations.
/// </summary>
[OpenXmlType(typeof(DXO19WC.CommentId))]
[XmlRoot("CommentId", Namespace = "DocumentModel.Wordprocessing")]
public partial class CommentId : ModelElement<DXO19WC.CommentId>
{
 /// <summary>
 ///   Hexadecimal identifier of the paragraph associated with this comment, used for precise paragraph-level tracking and navigation.
 /// </summary>
 [OpenXmlProperty(nameof(DXO19WC.CommentId.ParaId))]
 public HexInt? ParaId { get => _ParaId; set => UpdateField(ref _ParaId, value, nameof(ParaId)); }

 private HexInt? _ParaId;
 /// <summary>
 ///   Durable identifier that persists across document versions, platforms, and synchronization operations, providing a globally unique reference to the comment.
 /// </summary>
 [OpenXmlProperty(nameof(DXO19WC.CommentId.DurableId))]
 public HexInt? DurableId { get => _DurableId; set => UpdateField(ref _DurableId, value, nameof(DurableId)); }

 private HexInt? _DurableId;
}