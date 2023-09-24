namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a run of content in the parent field, hyperlink, custom XML element, structured document tag, smart tag, or paragraph.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  public HexBinary? RsidRunProperties { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  public HexBinary? RsidRunDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  public HexBinary? RsidRunAddition { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
