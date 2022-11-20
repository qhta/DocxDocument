namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFontReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectReference))]
public class ShapeStyle: IShapeStyle
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawing.ILineReference? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawing.IFillReference? FillReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawing.IEffectReference? EffectReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public DocumentModel.Drawing.IFontReference? FontReference
  {
    get;
    set;
  }
  
}
