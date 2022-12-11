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
  
  public NormalAutoFitImpl(): base() {}
  
  public NormalAutoFitImpl(DocumentFormat.OpenXml.Drawing.NormalAutoFit openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Font Scale
  /// </summary>
  public Int32? FontScale
  {
    get => (Int32?)OpenXmlElement?.FontScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Line Space Reduction
  /// </summary>
  public Int32? LineSpaceReduction
  {
    get => (Int32?)OpenXmlElement?.LineSpaceReduction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LineSpaceReduction = (System.Int32?)value;
    }
  }
  
}
