namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldGroup Class.
/// </summary>
public interface FieldGroup // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Parent
  /// </summary>
  public UInt32? ParentId { get ; set; }
  
  /// <summary>
  /// Field Base
  /// </summary>
  public UInt32? Base { get ; set; }
  
  public RangeProperties? RangeProperties { get ; set; }
  
  public DiscreteProperties? DiscreteProperties { get ; set; }
  
  public GroupItems? GroupItems { get ; set; }
  
}
