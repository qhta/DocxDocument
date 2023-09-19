namespace DocumentModel.UI;


/// <summary>
///   Defines the RepurposedCommand Class.
/// </summary>
public partial class RepurposedCommand
{
  
  /// <summary>
  ///   onAction
  /// </summary>
  [SchemaAttr("onAction")]
  public String? OnAction { get; set; }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [SchemaAttr("enabled")]
  public Boolean? Enabled { get; set; }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [SchemaAttr("getEnabled")]
  public String? GetEnabled { get; set; }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
}
