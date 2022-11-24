namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
public interface IRgbColorModelHex // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
