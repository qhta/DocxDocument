namespace DocumentModel.Spreadsheet;

/// <summary>
/// AutoFilter Settings.
/// </summary>
public interface IAutoFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cell or Range Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
}
