namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMembers Class.
/// </summary>
public interface ICalculatedMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Calculated Members Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ICalculatedMember>? CalculatedMembers { get ; set; }
  
}
