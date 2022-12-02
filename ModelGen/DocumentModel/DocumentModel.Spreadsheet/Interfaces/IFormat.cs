namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format.
/// </summary>
public interface IFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Action
  /// </summary>
  public FormatActionKind? Action { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Pivot Table Location.
  /// </summary>
  public IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
