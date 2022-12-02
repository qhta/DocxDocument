namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public interface IPerson // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public System.String? Contact { get ; set; }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public DocumentModel.Wordprocessing.IPresenceInfo? PresenceInfo { get ; set; }
  
}
