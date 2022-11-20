namespace DocumentModel.Office.ActiveX;

/// <summary>
/// Defines the ActiveXObjectProperty Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.ActiveX.ISharedComFont))]
[ChildElementInfo(typeof(DocumentModel.Office.ActiveX.ISharedComPicture))]
public interface IActiveXObjectProperty // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public string? Value { get ; set; }
  
  /// <summary>
  /// SharedComFont.
  /// </summary>
  public ISharedComFont? SharedComFont { get ; set; }
  
  /// <summary>
  /// SharedComPicture.
  /// </summary>
  public ISharedComPicture? SharedComPicture { get ; set; }
  
}
