namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied to a set of latent styles for this document. Latent styles refer to any set of style definitions known to an application which have not been included in the current document.
/// </summary>
public partial class LatentStyles
{
  
  /// <summary>
  ///   Default Style Locking Setting
  /// </summary>
  [SchemaAttr("w:defLockedState")]
  public Boolean? DefaultLockedState { get; set; }
  
  
  /// <summary>
  ///   Default User Interface Priority Setting
  /// </summary>
  [SchemaAttr("w:defUIPriority")]
  public Int32? DefaultUiPriority { get; set; }
  
  
  /// <summary>
  ///   Default Semi-Hidden Setting
  /// </summary>
  [SchemaAttr("w:defSemiHidden")]
  public Boolean? DefaultSemiHidden { get; set; }
  
  
  /// <summary>
  ///   Default Hidden Until Used Setting
  /// </summary>
  [SchemaAttr("w:defUnhideWhenUsed")]
  public Boolean? DefaultUnhideWhenUsed { get; set; }
  
  
  /// <summary>
  ///   Default Primary Style Setting
  /// </summary>
  [SchemaAttr("w:defQFormat")]
  public Boolean? DefaultPrimaryStyle { get; set; }
  
  
  /// <summary>
  ///   Latent Style Count
  /// </summary>
  [SchemaAttr("w:count")]
  public Int32? Count { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? Items { get; set; }
  
}
