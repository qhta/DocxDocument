namespace DocumentModel;

/// <summary>
/// Defines the BackstageTab Class.
/// </summary>
public partial class BackstageTab
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso { get; set; }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertAfterQulifiedId { get; set; }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InsertBeforeQulifiedId { get; set; }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Enabled { get; set; }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetEnabled { get; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Keytip { get; set; }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetKeytip { get; set; }
  
  /// <summary>
  /// title, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Title { get; set; }
  
  /// <summary>
  /// getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetTitle { get; set; }
  
  /// <summary>
  /// columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColumnWidthPercent { get; set; }
  
  /// <summary>
  /// firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstColumnMinWidth { get; set; }
  
  /// <summary>
  /// firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstColumnMaxWidth { get; set; }
  
  /// <summary>
  /// secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondColumnMinWidth { get; set; }
  
  /// <summary>
  /// secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondColumnMaxWidth { get; set; }
  
  /// <summary>
  /// BackstageGroups.
  /// </summary>
  public DocumentModel.BackstageGroups? BackstageGroups { get; set; }
  
  /// <summary>
  /// SimpleGroups.
  /// </summary>
  public DocumentModel.SimpleGroups? SimpleGroups { get; set; }
  
}
