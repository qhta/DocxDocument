namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public interface ILinearShadeProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Angle { get ; set; }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.OnOffKind? Scaled { get ; set; }
  
}
