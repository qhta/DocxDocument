namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public interface ISdtContentText // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public bool? MultiLine { get ; set; }
  
}
