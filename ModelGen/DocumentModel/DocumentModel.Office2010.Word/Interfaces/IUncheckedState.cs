namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the UncheckedState Class.
/// </summary>
public interface IUncheckedState // : DocumentFormat.OpenXml.Office2010.Word.CheckBoxSymbolType
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Font { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
