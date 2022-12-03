namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format.
/// </summary>
public interface Format // : DocumentModel.BaseTypes.ModelElement
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
  public PivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
