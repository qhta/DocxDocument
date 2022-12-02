namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public interface IFixedCommandKeyboardCustomization // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// fciName
  /// </summary>
  public System.String? CommandName { get ; set; }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public DocumentModel.IHexBinaryValue? CommandIndex { get ; set; }
  
  /// <summary>
  /// swArg
  /// </summary>
  public DocumentModel.IHexBinaryValue? Argument { get ; set; }
  
}
