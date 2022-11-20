namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the DefaultImageDpi Class.
/// </summary>
public interface IDefaultImageDpi // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Val { get ; set; }
  
}
