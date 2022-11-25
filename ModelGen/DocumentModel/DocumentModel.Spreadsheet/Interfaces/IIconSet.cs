namespace DocumentModel.Spreadsheet;

/// <summary>
/// Icon Set.
/// </summary>
public interface IIconSet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Icon Set
  /// </summary>
  public DocumentModel.Spreadsheet.IconSetKind? IconSetValue { get ; set; }
  
  /// <summary>
  /// Show Value
  /// </summary>
  public System.Boolean? ShowValue { get ; set; }
  
  /// <summary>
  /// Percent
  /// </summary>
  public System.Boolean? Percent { get ; set; }
  
  /// <summary>
  /// Reverse Icons
  /// </summary>
  public System.Boolean? Reverse { get ; set; }
  
}
