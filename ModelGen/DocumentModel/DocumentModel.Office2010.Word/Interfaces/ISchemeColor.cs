namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public interface ISchemeColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public SchemeColorValues? Val { get ; set; }
  
}
