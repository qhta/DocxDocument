namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the LabelControl Class.
/// </summary>
public interface ILabelControl // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get ; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get ; set; }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get ; set; }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get ; set; }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get ; set; }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get ; set; }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get ; set; }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get ; set; }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get ; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get ; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get ; set; }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get ; set; }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get ; set; }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get ; set; }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get ; set; }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowLabel { get ; set; }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetShowLabel { get ; set; }
  
}
