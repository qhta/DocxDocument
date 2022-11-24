namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public interface IBackgroundRemoval // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeTop { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeBottom { get ; set; }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeLeft { get ; set; }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeRight { get ; set; }
  
}
