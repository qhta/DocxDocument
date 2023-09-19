namespace DocumentModel;


/// <summary>
///   Defines the TaskFormGroup Class.
/// </summary>
public partial class TaskFormGroup
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
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("helperText")]
  public String? HelperText { get; set; }
  
  
  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getHelperText")]
  public String? GetHelperText { get; set; }
  
  
  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("showLabel")]
  public Boolean? ShowLabel { get; set; }
  
  
  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("getShowLabel")]
  public String? GetShowLabel { get; set; }
  
  
  /// <summary>
  ///   allowedTaskSizes, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("allowedTaskSizes")]
  public DocumentModel.TaskSizesValues? AllowedTaskSizes { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.TaskFormGroupCategory>? Items { get; set; }
  
}
