namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Panose1Number Class.
/// </summary>
public interface IPanose1Number // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
