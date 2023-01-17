namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public class CommentEx
{
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public NumId? ParaId { get; set; }

  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public NumId? ParaIdParent { get; set; }

  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done { get; set; }
}