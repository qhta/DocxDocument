namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public interface IDocGrid // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocumentModel.Wordprocessing.DocGridKind? Type { get ; set; }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  public System.Int32? LinePitch { get ; set; }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  public System.Int32? CharacterSpace { get ; set; }
  
}
