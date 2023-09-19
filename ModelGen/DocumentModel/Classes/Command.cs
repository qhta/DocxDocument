namespace DocumentModel;


/// <summary>
///   Defines the Command Class.
/// </summary>
public partial class Command
{
  
  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onAction")]
  public String? OnAction { get; set; }
  
  
  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("enabled")]
  public Boolean? Enabled { get; set; }
  
  
  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getEnabled")]
  public String? GetEnabled { get; set; }
  
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
}
