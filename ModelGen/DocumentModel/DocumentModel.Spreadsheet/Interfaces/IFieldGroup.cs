namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldGroup Class.
/// </summary>
public interface IFieldGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Parent
  /// </summary>
  public UInt32? ParentId { get ; set; }
  
  /// <summary>
  /// Field Base
  /// </summary>
  public UInt32? Base { get ; set; }
  
  public IRangeProperties? RangeProperties { get ; set; }
  
  public IDiscreteProperties? DiscreteProperties { get ; set; }
  
  public IGroupItems? GroupItems { get ; set; }
  
}
