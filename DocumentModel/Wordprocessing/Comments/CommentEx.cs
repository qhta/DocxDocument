namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public class CommentEx: ModelElement
{
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public HexInt? ParaIdParent { get; set; }

  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done { get; set; }
}