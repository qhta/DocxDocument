namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Attached Object Data.
/// </summary>
public interface IClientData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Object type
  /// </summary>
  public ObjectValues? ObjectType { get ; set; }
  
}
