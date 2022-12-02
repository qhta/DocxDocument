namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public interface INumericValue // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get ; set; }
  
}
