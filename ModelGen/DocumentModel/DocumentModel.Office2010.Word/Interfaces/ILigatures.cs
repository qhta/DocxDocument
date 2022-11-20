namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Ligatures Class.
/// </summary>
public interface ILigatures // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public LigaturesValues? Val { get ; set; }
  
}
