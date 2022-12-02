namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the GroupLevels Class.
/// </summary>
public interface IGroupLevels // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping Level Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IGroupLevel>? GroupLevels { get ; set; }
  
}
