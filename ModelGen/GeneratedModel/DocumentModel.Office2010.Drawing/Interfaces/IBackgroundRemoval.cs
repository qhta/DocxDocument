namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IBackgroundMark))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IForegroundMark))]
public interface IBackgroundRemoval // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public int? MarqueeTop { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public int? MarqueeBottom { get ; set; }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public int? MarqueeLeft { get ; set; }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public int? MarqueeRight { get ; set; }
  
}
