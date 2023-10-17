namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a run of content in the parent field, hyperlink, custom XML element, structured document tag, smart tag, or paragraph.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  public DM.HexBinary? RsidRunProperties { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  public DM.HexBinary? RsidRunDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  public DM.HexBinary? RsidRunAddition { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
