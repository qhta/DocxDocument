namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MoveBookmarkType Class.
/// </summary>
public class MoveBookmarkType: BodyElement, ParagraphElement
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   colFirst
  /// </summary>
  public Int32? ColumnFirst { get; set; }

  /// <summary>
  ///   colLast
  /// </summary>
  public Int32? ColumnLast { get; set; }

  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}