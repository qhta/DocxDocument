namespace DocumentModel.Office2013.Drawing.TimeSlicer;

/// <summary>
/// Defines the TimeSlicer Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.TimeSlicer.IOfficeArtExtensionList))]
public interface ITimeSlicer // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Drawing.TimeSlicer.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
