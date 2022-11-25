namespace DocumentModel.InkML;

/// <summary>
/// Defines the SampleRate Class.
/// </summary>
public interface ISampleRate // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// uniform
  /// </summary>
  public System.Boolean? Uniform { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public System.Decimal? Value { get ; set; }
  
}
