namespace DocumentModel.Presentation;

/// <summary>
/// Handout Master.
/// </summary>
public interface IHandoutMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// HandoutMasterExtensionList.
  /// </summary>
  public IHandoutMasterExtensionList? HandoutMasterExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the HandoutMasterPart associated with this element.
  /// </summary>
  public HandoutMasterPart? HandoutMasterPart { get ; set; }
  
}
