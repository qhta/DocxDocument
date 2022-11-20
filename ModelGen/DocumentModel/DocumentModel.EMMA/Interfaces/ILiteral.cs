namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Literal Class.
/// </summary>
public interface ILiteral // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
