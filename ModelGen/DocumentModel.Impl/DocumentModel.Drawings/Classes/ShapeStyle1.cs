namespace DocumentModel.Drawings;

/// <summary>
/// Style.
/// </summary>
public class ShapeStyle1Impl: ModelElementImpl, ShapeStyle1
{
  public DocumentFormat.OpenXml.Drawing.ShapeStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference1? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference1? FillReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference2? EffectReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public FontReference2? FontReference
  {
    get;
    set;
  }
  
}
