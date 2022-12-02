namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SetLevels Class.
/// </summary>
public interface ISetLevels // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ISetLevel>? SetLevels { get ; set; }
  
}
