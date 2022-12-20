namespace DocumentModel;

/// <summary>
/// Defines the BackstageEditBox Class.
/// </summary>
public partial interface BackstageEditBox
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
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? AlignLabel { get; set; }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Expand { get; set; }
  
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
  /// getText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetText { get; set; }
  
  /// <summary>
  /// onChange, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnChange { get; set; }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MaxLength { get; set; }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SizeString { get; set; }
  
}
