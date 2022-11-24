namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public interface ISdtContentText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine { get ; set; }
  
}
