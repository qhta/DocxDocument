namespace DocumentModel.Presentation;

/// <summary>
/// Shape Style.
/// </summary>
public interface IShapeStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public ILineReference? LineReference { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public IFillReference? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public IEffectReference? EffectReference { get ; set; }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public IFontReference? FontReference { get ; set; }
  
}
