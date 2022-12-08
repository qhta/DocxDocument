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
  
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy
  {
    get;
    set;
  }
  
}
