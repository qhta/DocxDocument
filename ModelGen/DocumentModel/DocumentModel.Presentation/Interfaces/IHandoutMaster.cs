namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master.
/// </summary>
public interface IHandoutMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
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
  public DocumentModel.BaseTypes.ModelElement? HandoutMasterExtensionList { get ; set; }
  
}
