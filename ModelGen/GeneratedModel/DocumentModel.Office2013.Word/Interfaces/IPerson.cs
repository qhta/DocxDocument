namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the Person Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.IPresenceInfo))]
public interface IPerson // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  [Obsolete("This property will not persist to the document and will be removed in a future version")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public string? Contact { get ; set; }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public DocumentModel.Office2013.Word.IPresenceInfo? PresenceInfo { get ; set; }
  
}
