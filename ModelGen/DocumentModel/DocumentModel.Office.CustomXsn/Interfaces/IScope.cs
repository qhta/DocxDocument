namespace DocumentModel.Office.CustomXsn;

/// <summary>
/// Defines the Scope Class.
/// </summary>
public interface IScope // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
