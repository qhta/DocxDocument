namespace DocumentModel.InkML;

/// <summary>
/// Defines the SampleRate Class.
/// </summary>
public interface ISampleRate // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// uniform
  /// </summary>
  public bool? Uniform { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public decimal? Value { get ; set; }
  
}
