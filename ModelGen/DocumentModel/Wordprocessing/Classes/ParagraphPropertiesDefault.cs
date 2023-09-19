namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a set of default paragraph properties for the current document. The actual paragraph properties are stored within the pPr child element of the current element.
/// </summary>
public partial class ParagraphPropertiesDefault
{
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle { get; set; }
  
}
