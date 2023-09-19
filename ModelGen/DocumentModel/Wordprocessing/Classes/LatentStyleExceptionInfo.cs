namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the properties which shall be applied a single latent style for this document. Latent styles refer to any set of known style definitions which have not been included in the current document.
/// </summary>
public partial class LatentStyleExceptionInfo
{
  
  /// <summary>
  ///   Primary Style Name
  /// </summary>
  [SchemaAttr("w:name")]
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Latent Style Locking Setting
  /// </summary>
  [SchemaAttr("w:locked")]
  public Boolean? Locked { get; set; }
  
  
  /// <summary>
  ///   Override default sorting order
  /// </summary>
  [SchemaAttr("w:uiPriority")]
  public Int32? UiPriority { get; set; }
  
  
  /// <summary>
  ///   Semi hidden text override
  /// </summary>
  [SchemaAttr("w:semiHidden")]
  public Boolean? SemiHidden { get; set; }
  
  
  /// <summary>
  ///   Unhide when used
  /// </summary>
  [SchemaAttr("w:unhideWhenUsed")]
  public Boolean? UnhideWhenUsed { get; set; }
  
  
  /// <summary>
  ///   Latent Style Primary Style Setting
  /// </summary>
  [SchemaAttr("w:qFormat")]
  public Boolean? PrimaryStyle { get; set; }
  
}
