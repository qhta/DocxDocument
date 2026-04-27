namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a endnote within a WordprocessingML document.
/// </summary>
/// <remarks>A EndnoteReference element is used to indicate the presence of a endnote at a specific location in
/// the document content. It links the main document text to the corresponding endnote entry, allowing applications to
/// display or process endnotes appropriately. This element is typically used when parsing or generating
/// WordprocessingML documents that include endnotes.</remarks>
[XmlRoot("EndnoteReference", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.EndnoteReference))]
public class EndnoteReference: ModelElement<DXW.EndnoteReference>
{
  /// <summary>
  /// <para>Suppress Endnote Reference Mark</para>
  /// </summary>
  public bool? CustomMarkFollows { get; set; }
  /// <summary>
  /// <para>Represents the following attribute in the schema: w:id</para>
  /// </summary>
  public int? Id { get; set; }
}