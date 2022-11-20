namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the CharacterInsertion Class.
/// </summary>
public interface ICharacterInsertion // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
