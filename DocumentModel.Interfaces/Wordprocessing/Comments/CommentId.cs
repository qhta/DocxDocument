namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents identifiers for a comment in a WordprocessingML document, providing both paragraph-level and durable identification.
/// </summary>
/// <remarks>
///   <para>
///   Comment identifiers are used to maintain stable references to comments across document operations,
///   synchronization, and platform transitions. This structure contains two types of identifiers that serve
///   different but complementary purposes in modern Word document workflows.
///   </para>
///   <para>
///   The dual-identifier approach supports:
///   <list type="bullet">
///   <item><description>Paragraph-level tracking of comment content structure</description></item>
///   <item><description>Global comment identification across document versions and platforms</description></item>
///   <item><description>Comment synchronization in co-authoring and cloud storage scenarios</description></item>
///   <item><description>Persistent comment references during document merge and compare operations</description></item>
///   </list>
///   </para>
///   <para>
///   These identifiers are particularly important in collaborative editing environments where multiple users
///   may be working on the same document simultaneously or where documents are edited across different platforms
///   (Word desktop, Word Online, Word mobile apps).
///   </para>
///   <para>
///   <b>Office Availability:</b> The CommentId structure with paragraph and durable identifiers was introduced
///   in Word 2013 as part of the enhanced comment tracking infrastructure. These identifiers enable improved
///   comment synchronization and persistence in modern Office 365 and Microsoft 365 collaborative workflows.
///   </para>
/// </remarks>
public interface CommentId : IModelElement
{
  /// <summary>
  ///   Gets or sets the hexadecimal identifier of the paragraph associated with this comment.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The paragraph identifier provides a reference to the specific paragraph within the comment's content
  ///   or the document paragraph to which the comment is anchored. This identifier enables:
  ///   <list type="bullet">
  ///   <item><description>Precise paragraph-level tracking within comment content structures</description></item>
  ///   <item><description>Efficient navigation to the comment's location in the document</description></item>
  ///   <item><description>Paragraph-specific revision tracking and change detection</description></item>
  ///   <item><description>Content synchronization across different editing sessions</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The paragraph ID uses a hexadecimal format to ensure compact storage while providing a large
  ///   identifier space. This format is consistent with other paragraph identifiers used throughout
  ///   the WordprocessingML schema.
  ///   </para>
  ///   <para>
  ///   Setting this to <see langword="null"/> indicates that no specific paragraph identifier is assigned,
  ///   which may occur in legacy documents or when paragraph-level tracking is not enabled.
  ///   </para>
  /// </remarks>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   Gets or sets the durable identifier that persists across document versions, platforms, and synchronization operations.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The durable identifier provides a globally unique, stable reference to the comment that remains
  ///   consistent throughout the comment's lifetime, regardless of document modifications, platform changes,
  ///   or synchronization events. Unlike temporary or session-based identifiers, the durable ID is designed
  ///   to persist indefinitely.
  ///   </para>
  ///   <para>
  ///   Durable identifiers are critical for:
  ///   <list type="bullet">
  ///   <item><description>Maintaining comment references during cloud synchronization (OneDrive, SharePoint)</description></item>
  ///   <item><description>Tracking comments across co-authoring sessions with multiple simultaneous editors</description></item>
  ///   <item><description>Preserving comment associations when documents are merged or compared</description></item>
  ///   <item><description>Enabling consistent comment status (resolved/unresolved) across all platforms</description></item>
  ///   <item><description>Supporting offline editing with later synchronization of comment changes</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The durable identifier uses a hexadecimal format and is typically generated as a GUID-based value
  ///   to ensure global uniqueness. This identifier should never be reused, even if the original comment
  ///   is deleted and a new comment is created.
  ///   </para>
  ///   <para>
  ///   Setting this to <see langword="null"/> indicates that no durable identifier is assigned, which may
  ///   limit the comment's trackability in collaborative and multi-platform scenarios. Applications should
  ///   assign durable identifiers when creating new comments to ensure full functionality.
  ///   </para>
  /// </remarks>
  public HexInt? DurableId { get; set; }
}