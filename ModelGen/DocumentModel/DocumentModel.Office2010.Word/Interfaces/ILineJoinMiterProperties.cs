namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public interface ILineJoinMiterProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Limit { get ; set; }
  
}
