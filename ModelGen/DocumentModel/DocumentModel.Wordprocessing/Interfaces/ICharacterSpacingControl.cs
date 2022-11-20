namespace DocumentModel.Wordprocessing;

/// <summary>
/// Character-Level Whitespace Compression.
/// </summary>
public interface ICharacterSpacingControl // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public CharacterSpacingValues? Val { get ; set; }
  
}
