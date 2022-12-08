namespace DocumentModel.Drawings;

/// <summary>
/// Normal AutoFit.
/// </summary>
public class NormalAutoFitImpl: ModelElementImpl, NormalAutoFit
{
  public DocumentFormat.OpenXml.Drawing.NormalAutoFit? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NormalAutoFit?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Font Scale
  /// </summary>
  public Int32? FontScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  public Int32? LineSpaceReduction
  {
    get;
    set;
  }
  
}
