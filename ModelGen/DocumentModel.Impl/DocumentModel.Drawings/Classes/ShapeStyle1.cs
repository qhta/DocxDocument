namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
public class ShapeStyle1Impl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>, ShapeStyle1
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference2? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference2? FillReference
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
