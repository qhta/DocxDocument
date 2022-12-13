namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public class PositiveSize2DTypeImpl: ModelElementImpl, PositiveSize2DType
{
  public DocumentFormat.OpenXml.Drawing.PositiveSize2DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PositiveSize2DType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PositiveSize2DTypeImpl(): base() {}
  
  public PositiveSize2DTypeImpl(DocumentFormat.OpenXml.Drawing.PositiveSize2DType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx
  {
    get => (System.Int64?)OpenXmlElement?.Cx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Cx = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy
  {
    get => (System.Int64?)OpenXmlElement?.Cy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Cy = (System.Int64?)value;
    }
  }
  
}
