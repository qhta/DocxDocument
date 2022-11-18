namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IDegree))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.IRadicalProperties))]
public interface IRadical // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public IRadicalProperties? RadicalProperties { get ; set; }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public IDegree? Degree { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
