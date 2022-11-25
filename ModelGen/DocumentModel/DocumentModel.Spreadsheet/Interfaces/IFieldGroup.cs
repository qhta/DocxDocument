namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldGroup Class.
/// </summary>
public interface IFieldGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Parent
  /// </summary>
  public System.UInt32? ParentId { get ; set; }
  
  /// <summary>
  /// Field Base
  /// </summary>
  public System.UInt32? Base { get ; set; }
  
}
