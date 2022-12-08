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
    get;
    set;
  }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public DocumentModel.HexBinaryValue? CommandIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// swArg
  /// </summary>
  public DocumentModel.HexBinaryValue? Argument
  {
    get;
    set;
  }
  
}
