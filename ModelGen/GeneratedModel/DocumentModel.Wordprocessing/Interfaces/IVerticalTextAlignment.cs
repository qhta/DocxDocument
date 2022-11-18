namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalTextAlignment Class.
/// </summary>
public interface IVerticalTextAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Subscript/Superscript Value
  /// </summary>
  public VerticalPosition? Val { get ; set; }
  
}
