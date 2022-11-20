namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Type.
/// </summary>
public interface IDocPartType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Type Value
  /// </summary>
  public DocPartValues? Val { get ; set; }
  
}
