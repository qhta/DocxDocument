namespace DocumentModel;


/// <summary>
///   Defines the BackstageEditBox Class.
/// </summary>
public partial class BackstageEditBox
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("idQ")]
  public String? QualifiedId { get; set; }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("tag")]
  public String? Tag { get; set; }
  
  
  /// <summary>
  ///   alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("alignLabel")]
  public DocumentModel.ExpandValues? AlignLabel { get; set; }
  
  
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("expand")]
  public DocumentModel.ExpandValues? Expand { get; set; }
  
  
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
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("label")]
  public String? Label { get; set; }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getLabel")]
  public String? GetLabel { get; set; }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("visible")]
  public Boolean? Visible { get; set; }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getVisible")]
  public String? GetVisible { get; set; }
  
  
  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("keytip")]
  public String? Keytip { get; set; }
  
  
  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getKeytip")]
  public String? GetKeytip { get; set; }
  
  
  /// <summary>
  ///   getText, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getText")]
  public String? GetText { get; set; }
  
  
  /// <summary>
  ///   onChange, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("onChange")]
  public String? OnChange { get; set; }
  
  
  /// <summary>
  ///   maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("maxLength")]
  public Int64? MaxLength { get; set; }
  
  
  /// <summary>
  ///   sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("sizeString")]
  public String? SizeString { get; set; }
  
}
