namespace DocumentModel.Office2013.Theme;

/// <summary>
/// Defines the ThemeVariant Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Theme.IOfficeArtExtensionList))]
public interface IThemeVariant // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Vid { get ; set; }
  
  /// <summary>
  /// cx, this property is only available in Office 2013 and later.
  /// </summary>
  public long? X { get ; set; }
  
  /// <summary>
  /// cy, this property is only available in Office 2013 and later.
  /// </summary>
  public long? Y { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Theme.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
