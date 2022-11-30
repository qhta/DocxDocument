namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMembers Class.
/// </summary>
public interface ICalculatedMembers // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Calculated Members Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICalculatedMember>? CalculatedMembers { get ; set; }
  
}
