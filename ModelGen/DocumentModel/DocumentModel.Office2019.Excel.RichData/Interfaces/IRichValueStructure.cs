namespace DocumentModel.Office2019.Excel.RichData;

/// <summary>
/// Defines the RichValueStructure Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData.IKey))]
public interface IRichValueStructure // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// t, this property is only available in Office 2019 and later.
  /// </summary>
  public string? T { get ; set; }
  
}
