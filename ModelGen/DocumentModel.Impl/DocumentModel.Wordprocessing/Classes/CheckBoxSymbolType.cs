namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public class CheckBoxSymbolTypeImpl: ModelElementImpl, CheckBoxSymbolType
{
  public DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Font
  {
    get;
    set;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? Val
  {
    get;
    set;
  }
  
}
