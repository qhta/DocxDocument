namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the DefaultImageDpi Class.
/// </summary>
public interface IDefaultImageDpi // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Val { get ; set; }
  
}
