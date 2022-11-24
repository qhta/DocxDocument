namespace DocumentModel.Drawing;

/// <summary>
/// RGB Color Model - Hex Variant.
/// </summary>
public interface IRgbColorModelHex // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
  /// <summary>
  /// legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? LegacySpreadsheetColorIndex { get ; set; }
  
}
