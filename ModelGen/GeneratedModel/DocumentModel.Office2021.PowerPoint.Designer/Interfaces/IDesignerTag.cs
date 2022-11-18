namespace DocumentModel.Office2021.PowerPoint.Designer;

/// <summary>
/// Defines the DesignerTag Class.
/// </summary>
public interface IDesignerTag // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}
