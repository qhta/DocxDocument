namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public interface IFixedCommandKeyboardCustomization // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// fciName
  /// </summary>
  public string? CommandName { get ; set; }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public IHexBinaryValue? CommandIndex { get ; set; }
  
  /// <summary>
  /// swArg
  /// </summary>
  public IHexBinaryValue? Argument { get ; set; }
  
}
