namespace DocumentModel.Office2013.ExcelAc;

/// <summary>
/// Defines the AbsolutePath Class.
/// </summary>
public interface IAbsolutePath // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// url, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Url { get ; set; }
  
}
