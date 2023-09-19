namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a run of content in the parent field, hyperlink, custom XML element, structured document tag, smart tag, or paragraph.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [SchemaAttr("w:rsidRPr")]
  public DocumentModel.HexBinaryValue? RsidRunProperties { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [SchemaAttr("w:rsidDel")]
  public DocumentModel.HexBinaryValue? RsidRunDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [SchemaAttr("w:rsidR")]
  public DocumentModel.HexBinaryValue? RsidRunAddition { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
