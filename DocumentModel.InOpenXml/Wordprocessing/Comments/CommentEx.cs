namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies additional information for a single comment in the current document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for the paragraph identifier of the last paragraph in the comment, the parent comment's last paragraph identifier, and the completion status, enabling advanced tracking and management of comment threads and resolution status.
/// </summary>
[OpenXmlType(typeof(DXO13W.CommentEx))]
[DataContract]
[XmlRoot("CommentEx", Namespace = "DocumentModel.Wordprocessing")]
public partial class CommentEx: ModelElement<DXO13W.CommentEx>
{
  /// <summary>
  /// Paragraph identifier (paraId) of the last paragraph in the associated comment.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13W.CommentEx.ParaId))]
  public HexInt? ParaId
  {
    get => _ParaId ??= GetProperty<HexInt?>(GetUpdatableElement()?.ParaId);
    set => UpdateField(ref _ParaId, value, nameof(ParaId));
  }

  private HexInt? _ParaId;

  /// <summary>
  /// Paragraph identifier (paraId) of the last paragraph in the parent comment to which the associated comment is a reply.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13W.CommentEx.ParaIdParent))]
  public HexInt? ParaIdParent
  {
    get => _ParaIdParent ??= GetProperty<HexInt?>(GetUpdatableElement()?.ParaIdParent);
    set => UpdateField(ref _ParaIdParent, value, nameof(ParaIdParent));
  }

  private HexInt? _ParaIdParent;

  /// <summary>
  /// Indicates whether the associated comment is marked as done (resolved).
  /// </summary>
  [OpenXmlProperty(nameof(DXO13W.CommentEx.Done))]
  public bool? Done
  {
    get => _Done ??= GetProperty<bool?>(GetUpdatableElement()?.Done);
    set => UpdateField(ref _Done, value, nameof(Done));
  }

  private bool? _Done;
}