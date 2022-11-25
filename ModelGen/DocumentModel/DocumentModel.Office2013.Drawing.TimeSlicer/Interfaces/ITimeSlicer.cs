namespace DocumentModel.Office2013.Drawing.TimeSlicer;

/// <summary>
/// Defines the TimeSlicer Class.
/// </summary>
public interface ITimeSlicer // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
