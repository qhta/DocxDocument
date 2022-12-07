namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenFillProperties Class.
/// </summary>
public class HiddenFillPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>, HiddenFillProperties
{
  /// <summary>
  /// SolidFill.
  /// </summary>
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public BlipFill1? BlipFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
}
