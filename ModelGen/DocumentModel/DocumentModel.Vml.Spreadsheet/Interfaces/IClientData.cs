namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Attached Object Data.
/// </summary>
public interface IClientData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Object type
  /// </summary>
  public DocumentModel.Vml.Spreadsheet.ObjectKind? ObjectType { get ; set; }
  
}
