namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the GroupLevels Class.
/// </summary>
public interface IGroupLevels // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping Level Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IGroupLevel>? GroupLevels { get ; set; }
  
}
