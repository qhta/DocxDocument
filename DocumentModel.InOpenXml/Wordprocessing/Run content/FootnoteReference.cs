namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a footnote within a WordprocessingML document.
/// </summary>
/// <remarks>A FootnoteReference element is used to indicate the presence of a footnote at a specific location in
/// the document content. It links the main document text to the corresponding footnote entry, allowing applications to
/// display or process footnotes appropriately. This element is typically used when parsing or generating
/// WordprocessingML documents that include footnotes.</remarks>
[DataContract]
[XmlRoot("FootnoteReference", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.FootnoteReference))]
public class FootnoteReference: ModelElement<DXW.FootnoteReference>
{
  /// <summary>
  /// <para>Suppress Footnote Reference Mark</para>
  /// </summary>
  public bool? CustomMarkFollows { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// <para>Represents the following attribute in the schema: w:id</para>
  /// </summary>
  public int? Id { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}