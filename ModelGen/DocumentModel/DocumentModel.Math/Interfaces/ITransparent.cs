namespace DocumentModel.Math;

/// <summary>
/// Transparent (Phantom).
/// </summary>
public interface ITransparent // : DocumentFormat.OpenXml.Math.OnOffType
{
  /// <summary>
  /// value
  /// </summary>
  public BooleanValues? Val { get ; set; }
  
}
