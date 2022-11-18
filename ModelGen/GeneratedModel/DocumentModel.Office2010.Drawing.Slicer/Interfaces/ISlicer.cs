namespace DocumentModel.Office2010.Drawing.Slicer;

/// <summary>
/// Defines the Slicer Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Slicer.IOfficeArtExtensionList))]
public interface ISlicer // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Drawing.Slicer.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
