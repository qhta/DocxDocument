namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the BackstageEditBox Class.
/// </summary>
public interface IBackstageEditBox // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public Expand? AlignLabel { get ; set; }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public Expand? Expand { get ; set; }
  
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
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get ; set; }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get ; set; }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get ; set; }
  
  /// <summary>
  /// getText, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetText { get ; set; }
  
  /// <summary>
  /// onChange, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnChange { get ; set; }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public int? MaxLength { get ; set; }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public string? SizeString { get ; set; }
  
}
