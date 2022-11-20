namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Pitch Class.
/// </summary>
public interface IPitch // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public FontPitchValues? Val { get ; set; }
  
}
