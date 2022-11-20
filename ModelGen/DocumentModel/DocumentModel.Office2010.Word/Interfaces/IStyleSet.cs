namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public interface IStyleSet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffValues? Val { get ; set; }
  
}
