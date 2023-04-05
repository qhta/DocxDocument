namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BookmarkStart Class.
/// </summary>
public class BookmarkStart: ModelElement, ICommonContent, IRangeMarkupElement
{
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