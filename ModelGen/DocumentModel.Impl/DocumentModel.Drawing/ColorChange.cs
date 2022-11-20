namespace DocumentModel.Drawing;

/// <summary>
/// Color Change Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorFrom))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorTo))]
public class ColorChange: IColorChange
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public bool? UseAlpha
  {
    get;
    set;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public IColorFrom? ColorFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public IColorTo? ColorTo
  {
    get;
    set;
  }
  
}
