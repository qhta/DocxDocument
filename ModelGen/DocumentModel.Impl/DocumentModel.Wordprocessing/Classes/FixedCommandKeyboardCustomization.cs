namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public class FixedCommandKeyboardCustomizationImpl: ModelElementImpl, FixedCommandKeyboardCustomization
{
  public DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// fciName
  /// </summary>
  public String? CommandName
  {
    get => (String?)OpenXmlElement?.CommandName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CommandName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public DocumentModel.HexBinaryValue? CommandIndex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  public DocumentModel.HexBinaryValue? Argument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
