namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public interface IFitText // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public uint? Val { get ; set; }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public int? Id { get ; set; }
  
}
