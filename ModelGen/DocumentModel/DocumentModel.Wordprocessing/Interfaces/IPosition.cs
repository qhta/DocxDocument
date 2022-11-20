namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Position Class.
/// </summary>
public interface IPosition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Signed Half-Point Measurement
  /// </summary>
  public string? Val { get ; set; }
  
}
