namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMatchSource))]
public interface IAltChunkProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public IMatchSource? MatchSource { get ; set; }
  
}
