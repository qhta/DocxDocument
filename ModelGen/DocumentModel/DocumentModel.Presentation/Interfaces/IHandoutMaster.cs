namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMap))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHandoutMasterExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHeaderFooter))]
public interface IHandoutMaster // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public DocumentModel.Presentation.IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Presentation.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// HandoutMasterExtensionList.
  /// </summary>
  public IHandoutMasterExtensionList? HandoutMasterExtensionList { get ; set; }
  
}
