namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Type.
/// </summary>
public interface IDocPartType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Type Value
  /// </summary>
  public DocPart? Val { get ; set; }
  
}
