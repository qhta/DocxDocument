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
  
  public DocumentModel.Spreadsheet.IRangeProperties? RangeProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.IDiscreteProperties? DiscreteProperties { get ; set; }
  
  public DocumentModel.Spreadsheet.IGroupItems? GroupItems { get ; set; }
  
}
