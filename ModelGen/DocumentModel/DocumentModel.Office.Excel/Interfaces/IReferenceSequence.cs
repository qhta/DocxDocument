namespace DocumentModel.Office.Excel;

/// <summary>
/// Defines the ReferenceSequence Class.
/// </summary>
public interface IReferenceSequence // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
