namespace DocumentModel;


/// <summary>
///   Defines the BackstageTab Class.
/// </summary>
public partial class BackstageTab
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
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("idMso")]
  public String? IdMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertAfterMso")]
  public String? InsertAfterMso { get; set; }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertBeforeMso")]
  public String? InsertBeforeMso { get; set; }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertAfterQ")]
  public String? InsertAfterQulifiedId { get; set; }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("insertBeforeQ")]
  public String? InsertBeforeQulifiedId { get; set; }
  
  
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
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getTitle")]
  public String? GetTitle { get; set; }
  
  
  /// <summary>
  ///   columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("columnWidthPercent")]
  public Int64? ColumnWidthPercent { get; set; }
  
  
  /// <summary>
  ///   firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("firstColumnMinWidth")]
  public Int64? FirstColumnMinWidth { get; set; }
  
  
  /// <summary>
  ///   firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("firstColumnMaxWidth")]
  public Int64? FirstColumnMaxWidth { get; set; }
  
  
  /// <summary>
  ///   secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("secondColumnMinWidth")]
  public Int64? SecondColumnMinWidth { get; set; }
  
  
  /// <summary>
  ///   secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("secondColumnMaxWidth")]
  public Int64? SecondColumnMaxWidth { get; set; }
  
  
  /// <summary>
  ///   BackstageGroups.
  /// </summary>
  public DocumentModel.BackstageGroups? BackstageGroups { get; set; }
  
  
  /// <summary>
  ///   SimpleGroups.
  /// </summary>
  public DocumentModel.SimpleGroups? SimpleGroups { get; set; }
  
}
