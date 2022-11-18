namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition Type.
/// </summary>
public interface IMultiLevelType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Abstract Numbering Definition Type
  /// </summary>
  public MultiLevel? Val { get ; set; }
  
}
