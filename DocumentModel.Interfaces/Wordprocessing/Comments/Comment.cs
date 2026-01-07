namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a single comment annotation stored in the Comments part of a WordprocessingML document.
/// </summary>
/// <remarks>
///   <para>
///   Comments are annotations that allow users to add notes, feedback, and editorial remarks to specific
///   locations within a Word document without modifying the main document content. Each comment is stored
///   separately in the Comments part and is linked to document content through comment range markers.
///   </para>
///   <para>
///   Comments in Word documents support:
///   <list type="bullet">
///   <item><description>Rich text content including paragraphs, formatting, tables, and images</description></item>
///   <item><description>Author attribution and tracking through name and initials</description></item>
///   <item><description>Timestamp information for creation and modification dates</description></item>
///   <item><description>Threaded discussions with nested replies to comments</description></item>
///   <item><description>Durable identifiers for persistent comment tracking across document versions</description></item>
///   </list>
///   </para>
///   <para>
///   Comments are displayed in the document margin or in a separate review pane, depending on the
///   viewing mode. Users can add, edit, resolve, or delete comments during the document review process.
///   Comments are essential for collaborative editing workflows and document review cycles.
///   </para>
///   <para>
///   <b>Office Availability:</b> Comments are supported in Word 2007 and later versions. Enhanced features
///   such as durable identifiers and paragraph identifiers were introduced in Word 2013 and later to improve
///   comment tracking and synchronization across platforms, including Word Online and mobile applications.
///   </para>
/// </remarks>
public interface Comment : CollectionItem, ElementCollection<CommentContent>
{
  /// <summary>
  ///   Gets or sets the unique identifier for this comment annotation.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The identifier uniquely distinguishes this comment from all other comments in the document.
  ///   This ID is used to:
  ///   <list type="bullet">
  ///   <item><description>Link comment range markers in the main document to the comment content</description></item>
  ///   <item><description>Associate comment replies with their parent comments</description></item>
  ///   <item><description>Reference comments in revision tracking and change history</description></item>
  ///   <item><description>Enable programmatic access to specific comments through the Word object model</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The ID must be unique within the scope of the Comments part. When creating new comments,
  ///   applications should assign sequential or unique identifiers to avoid conflicts.
  ///   </para>
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the name of the author who created this comment.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The author name is displayed in the comment balloon, review pane, and any user interface
  ///   elements that show comment information. This helps users identify who provided the feedback
  ///   or made the annotation during collaborative document editing.
  ///   </para>
  ///   <para>
  ///   The author name typically corresponds to the user account name or display name configured
  ///   in the Office application settings. When multiple users review a document, distinct author
  ///   names enable clear attribution of comments and facilitate communication among reviewers.
  ///   </para>
  /// </remarks>
  public string? Author { get; set; }

  /// <summary>
  ///   Gets or sets the initials of the comment author.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The initials provide a compact representation of the author's identity, useful for displaying
  ///   comment information in space-constrained user interfaces or when formatting comment blocks.
  ///   Initials are typically derived from the author's full name (e.g., "JD" for "John Doe").
  ///   </para>
  ///   <para>
  ///   Applications may use initials to:
  ///   <list type="bullet">
  ///   <item><description>Display abbreviated author identification in comment balloons</description></item>
  ///   <item><description>Color-code comments by author when multiple reviewers are involved</description></item>
  ///   <item><description>Provide quick visual distinction between different comment authors</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   If multiple authors share the same initials, applications may display the full author name
  ///   to avoid ambiguity and ensure clear identification of comment sources.
  ///   </para>
  /// </remarks>
  public string? Initials { get; set; }

  /// <summary>
  ///   Gets or sets the date and time when this comment was created or last modified.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The date information provides temporal context for the comment, helping users understand
  ///   when feedback was provided and track the chronological progression of document review activities.
  ///   This timestamp is particularly valuable in collaborative workflows where multiple review cycles occur.
  ///   </para>
  ///   <para>
  ///   Applications typically display the comment date in the user interface alongside the author
  ///   information. The date may be shown in various formats depending on user preferences and
  ///   localization settings (e.g., "3/15/2024 2:30 PM" or "March 15, 2024").
  ///   </para>
  ///   <para>
  ///   Setting this to <see langword="null"/> indicates that no specific date is recorded for the comment,
  ///   though this is uncommon in practice as most applications automatically set the date when creating comments.
  ///   </para>
  /// </remarks>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Gets or sets the hexadecimal identifier of the first paragraph in the comment content.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The paragraph identifier provides a persistent reference to the first paragraph within the
  ///   comment's content structure. This identifier is used for:
  ///   <list type="bullet">
  ///   <item><description>Tracking paragraph-level changes and revisions within comment content</description></item>
  ///   <item><description>Maintaining structural relationships in complex comment hierarchies</description></item>
  ///   <item><description>Synchronizing comment content across different platforms and devices</description></item>
  ///   <item><description>Enabling efficient content diffing and merge operations</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   This feature was introduced in Word 2013 to improve comment tracking and synchronization,
  ///   particularly for collaborative editing scenarios involving Word Online and mobile applications.
  ///   </para>
  /// </remarks>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   Gets or sets the durable identifier that persists across document versions and platforms.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The durable identifier provides a stable, globally unique reference to the comment that remains
  ///   consistent even when the document is edited, saved, or synchronized across different platforms
  ///   (desktop Word, Word Online, mobile apps). Unlike the regular <see cref="Id"/> which may change
  ///   during document operations, the durable ID is designed to persist throughout the comment's lifetime.
  ///   </para>
  ///   <para>
  ///   Durable identifiers are essential for:
  ///   <list type="bullet">
  ///   <item><description>Tracking comments across cloud synchronization and co-authoring sessions</description></item>
  ///   <item><description>Maintaining comment references when documents are merged or compared</description></item>
  ///   <item><description>Enabling consistent comment resolution status across platforms</description></item>
  ///   <item><description>Supporting offline editing with later synchronization of comment changes</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   This feature was introduced in Word 2013 as part of the enhanced collaboration infrastructure
  ///   to support modern cloud-based document editing workflows.
  ///   </para>
  /// </remarks>
  public HexInt? DurableId { get; set; }
}