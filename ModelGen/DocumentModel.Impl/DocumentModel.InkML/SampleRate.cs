namespace DocumentModel.InkML;

/// <summary>
/// Defines the SampleRate Class.
/// </summary>
public class SampleRate: ISampleRate
{
  /// <summary>
  /// uniform
  /// </summary>
  public bool? Uniform
  {
    get;
    set;
  }
  
  /// <summary>
  /// value
  /// </summary>
  public decimal? Value
  {
    get;
    set;
  }
  
}
