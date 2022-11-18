namespace DocumentModel.Wordprocessing;

/// <summary>
/// Endnote Placement.
/// </summary>
public interface IEndnotePosition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Endnote Position Type
  /// </summary>
  public EndnotePosition? Val { get ; set; }
  
}
