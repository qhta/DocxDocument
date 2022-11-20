namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the SupportingPropertyBagKey Class.
/// </summary>
public interface ISupportingPropertyBagKey // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// n, this property is only available in Office 2019 and later.
  /// </summary>
  public string? N { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2019 and later.
  /// </summary>
  public SupportingPropertyBagValueType? T { get ; set; }
  
}
