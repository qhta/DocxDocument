namespace DocumentModel.InkML;

/// <summary>
/// Defines the SampleRate Class.
/// </summary>
public interface ISampleRate // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// uniform
  /// </summary>
  public Boolean? Uniform { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public Decimal? Value { get ; set; }
  
}
