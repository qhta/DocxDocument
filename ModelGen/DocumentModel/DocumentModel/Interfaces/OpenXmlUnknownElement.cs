namespace DocumentModel;

/// <summary>
/// Represents elements that are not defined in the Office Open XML ECMA standard.
/// </summary>
public interface OpenXmlUnknownElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Gets the text of the unknown element, only if the unknown element
  /// </summary>
  public String? Text { get ; set; }
  
}
