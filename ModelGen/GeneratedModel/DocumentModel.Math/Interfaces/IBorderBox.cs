namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBorderBoxProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public interface IBorderBox // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public IBorderBoxProperties? BorderBoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
