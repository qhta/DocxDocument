namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public interface IAltChunkProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public System.Boolean? MatchSource { get ; set; }
  
}
