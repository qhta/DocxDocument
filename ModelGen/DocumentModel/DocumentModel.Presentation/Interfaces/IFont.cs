namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Font Name.
/// </summary>
public interface IFont // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Text Typeface
  /// </summary>
  public System.String? Typeface { get ; set; }
  
  /// <summary>
  /// Panose Setting
  /// </summary>
  public DocumentModel.IHexBinaryValue? Panose { get ; set; }
  
  /// <summary>
  /// Similar Font Family
  /// </summary>
  public System.SByte? PitchFamily { get ; set; }
  
  /// <summary>
  /// Similar Character Set
  /// </summary>
  public System.SByte? CharacterSet { get ; set; }
  
}
